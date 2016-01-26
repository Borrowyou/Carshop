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
    class ModelSearcher
    {
        WebBrowser wbTest;
        CarShopDataSet DSCarShop;
        int Model_ID = 1;
       
        public ModelSearcher()
       {
           this.wbTest = new WebBrowser();
           this.DSCarShop = new CarShopDataSet();
           DSCarShop.InitAdapters();
       }

       public WebBrowser PwbTest
       {
           get { return this.wbTest;
               }
           set{
               this.wbTest = null;
              } 
       }

        public void InitSiteConnection()
        {
            wbTest = new WebBrowser();
            wbTest.Url = new Uri("http://www.avto.bim.bg/tursene/pt1");
            wbTest.ScriptErrorsSuppressed = true;
            while (wbTest.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }
        public void CycleModels(XmlWriter writer, int Car_ID)
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
                        writer.WriteElementString("YEAR_MANUF",  ModelData[1].Substring(0,4));
                    if (ModelData.Length > 2)
                        writer.WriteElementString("YEAR_STOP", ModelData[2].Substring(0,4));

                    writer.WriteElementString("CAR_ID", Car_ID.ToString());
                    Model_ID++;
                    writer.WriteEndElement();
                }
            }
        }
        public void CycleMarksAndGetModels()
        {

            var MarkSelect = wbTest.Document.GetElementById("search_brand_id"); // get the mark 
            var ModelSelect = wbTest.Document.GetElementById("model_id"); // get model select
            mshtml.HTMLSelectElement AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            for (int i = 1; i < AllCars.length; i++)
            {
                AllCars.selectedIndex = i;
                CommonFuncs.InvokeOnChange(MarkSelect, ModelSelect);
                
                int CarID = DSCarShop.GEN_ID("Cars");
                DSCarShop.CarsTblAdapter.Insert(CarID, MarkSelect.Children[i].InnerText);
                for (int k = 1; k < AllModels.length; k++)
                {
                    string[] ModelData = CommonFuncs.ModelNameExtract(ModelSelect, k);
                    int ModelID = DSCarShop.GEN_ID("Models");
                    int? YearManuf = CommonFuncs.StringToNInt(ModelData[1]);
                    int? YearStop = CommonFuncs.StringToNInt(ModelData[2]);
                    DSCarShop.ModelsTblAdapter.Insert(ModelID, ModelData[0], YearManuf, YearStop, CarID, null);
                }
            }
        }
        public void SaveMaodelsToDB()
        {
            CarShopDataSet.ModelsDataTable DSModels = new CarShopDataSet.ModelsDataTable();
            int Rows = 0;
            String Model_Name = string.Empty;
            XmlWriter XmlWRiter = XmlWriter.Create("Bla.xml");
            DSModels.WriteXml(XmlWRiter);
            try
            {
                DSModels.ReadXml("Models.xml");
                Rows = DSModels.Rows.Count - 1;
                CarShopDataSetTableAdapters.ModelsTableAdapter ModelAdapter = new CarShopDataSetTableAdapters.ModelsTableAdapter();
                ModelAdapter.Update(DSModels);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

    }
}
