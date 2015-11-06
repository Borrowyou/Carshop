using System;
using System.Net;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;


namespace Car
{
    public partial class Form1 : Form
    {
        private void InitSiteConnection()
        {
            
            wbTest.Url = new Uri("http://www.avto.bim.bg/tursene/pt1");
            wbTest.ScriptErrorsSuppressed = true;
            while (wbTest.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }
        private void GetCarMarks()
        {

            var MarkSelect = wbTest.Document.GetElementById("search_brand_id");
            string webtxt = String.Empty;

            int Car_ID = 1;
            using (XmlWriter writer = XmlWriter.Create("Cars.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Cars_Marks");

                foreach (HtmlElement OptionMark in MarkSelect.Children)
                {
                    if (OptionMark.InnerText != "---Марка---")
                    {
                        writer.WriteStartElement("Cars");
                        writer.WriteElementString("Car_ID", Car_ID.ToString());
                        writer.WriteElementString("Car_Model", OptionMark.InnerText);
                        Car_ID++;
                        writer.WriteEndElement();
                    }

                }
                writer.WriteEndElement();
                writer.WriteEndDocument();

            }

            System.Diagnostics.Process.Start("Cars.xml");
        }
 

        public void CycleModels(XmlWriter writer)
        {
            var ModelSelect = wbTest.Document.GetElementById("model_id"); // get model select

            mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            string menu = string.Empty;
            foreach (HtmlElement OptionMark in ModelSelect.Children)
            {
                if (OptionMark.InnerText != "---Модел---" && OptionMark.InnerText != "---Избери Модел---")
                {
                    writer.WriteStartElement("Models");
                    writer.WriteElementString("MODEL_ID", Model_ID.ToString());
                    menu = OptionMark.InnerText;
                    string[] Separator = { " от ", " до " };
                    string[] ModelData = menu.Split(Separator, StringSplitOptions.RemoveEmptyEntries);

                    writer.WriteElementString("MODEL_NAME", ModelData[0]);
                    if (ModelData.Length > 1)
                        writer.WriteElementString("YEAR_MANUF", ModelData[1]);
                    if (ModelData.Length > 2)
                        writer.WriteElementString("Year_STOP", ModelData[2]);

                    writer.WriteElementString("CAR_ID", "1");
                    Model_ID++;
                    writer.WriteEndElement();
                }
            }
        }


        private void CycleMarks()
        {
            var MarkSelect = wbTest.Document.GetElementById("search_brand_id");
            mshtml.HTMLSelectElement AllMark = MarkSelect.DomElement as mshtml.HTMLSelectElement;
            //for (int i = 0; i < AllMark.length; i++)
            // {
            AllMark.selectedIndex = 1;
            MarkSelect.RaiseEvent("onChange");
            while (wbTest.ReadyState != WebBrowserReadyState.Complete)
                Application.DoEvents();
            // }
            // AllMark.selectedIndex = 0;

        }



        private async void CycleMarksAndGetModels()
        {

            var MarkSelect = wbTest.Document.GetElementById("search_brand_id"); // get the mark 
            var ModelSelect = wbTest.Document.GetElementById("model_id"); // get model select
            mshtml.HTMLSelectElement AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            string menu = string.Empty;
            carsTableAdapter1.Fill(CDSCarShop.Cars);
            //CDSCarShop.Cars.First; 
            using (XmlWriter writer = XmlWriter.Create("Models.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Cars_Models");
            for (int i = 1; i < AllCars.length; i++)
            {   
                AllCars.selectedIndex = i;
                MarkSelect.RaiseEvent("onChange");
                while(AllModels.length<2)
                    await Task.Delay(50);
                CycleModels(writer);
                    
             }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            }
            
            System.Diagnostics.Process.Start("Models.xml");
        }

        private void SaveMaodelsToDB()
        {
            CarShopDataSet.ModelsDataTable DSModels = new CarShopDataSet.ModelsDataTable();
            int Model_ID, CarID, YearStart, Rows, YearStop = 0;
            String Model_Name = string.Empty;
            DSModels.ReadXml("Models.xml");
            Rows = DSModels.Rows.Count - 1;
            CarShopDataSetTableAdapters.ModelsTableAdapter ModelAdapter = new CarShopDataSetTableAdapters.ModelsTableAdapter();
            ModelAdapter.Update(DSModels);
        }
        private void SaveCarMarksToDB()
        {
            CarShopDataSet.CarsDataTable DSCar = new CarShopDataSet.CarsDataTable();
            int Car_ID = 0;
            String Car_Mark = string.Empty;
            DSCar.ReadXml("Cars.xml");
            try
            {

                CarShopDataSetTableAdapters.CarsTableAdapter CarsAdapter = new CarShopDataSetTableAdapters.CarsTableAdapter();
                for (int i = 0; i <= DSCar.Rows.Count - 1; i++)
                {
                    Car_ID = Convert.ToInt32(DSCar.Rows[i].ItemArray[0]);
                    Car_Mark = DSCar.Rows[i].ItemArray[1].ToString();
                    CarsAdapter.Insert(Car_ID, Car_Mark);
                }
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex.ToString());
            }



            while (wbTest.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitSiteConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetCarMarks();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveCarMarksToDB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //InitSiteConnection();
            CycleMarksAndGetModels();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveMaodelsToDB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CycleMarks();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CycleMarksAndGetModels();
        }

    }
}


