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
using System.Diagnostics;
using HtmlAgilityPack;
namespace Car
{
    public partial class Form1 : Form
    {
        CarSearch CarSearcher;
        ModelSearcher ModelSrch;
        PartLinkSearcher PartSearch;
        HttpWebRequest htpReq;
        int CurrentCar, CurrentModel;
        public delegate void SetBrowserElements();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModelSrch = new ModelSearcher();
            InitSiteConnection();
            HtmlAgilityPack.HtmlDocument CurrentDoc = new HtmlAgilityPack.HtmlDocument();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarSearcher = new CarSearch();
            this.webTest = CarSearcher.PwbTest;
            CarSearcher.InitSiteConnection();
            this.webTest = CarSearcher.PwbTest;
            webTest.Refresh();
            CarSearcher.GetCarMarks();
            CarSearcher.SaveCarMarksToDB();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            ModelSrch.InitSiteConnection();
            ModelSrch.CycleMarksAndGetModels();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PartSearch = new PartLinkSearcher();
            PartSearch.InitSiteConnection();
            PartSearch.CycleMarksAndGetModels();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CycleMarksAndGetModels();
        }

        public void InitSiteConnection()
        {

            webTest.Url = new Uri("http://www.avto.bim.bg/tursene/pt1");
            webTest.ScriptErrorsSuppressed = true;
            while (webTest.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }
        public void LoadSite(WebBrowser aWebBrowser, string sUrl)
        {
            aWebBrowser.Url = new Uri(sUrl);
            aWebBrowser.ScriptErrorsSuppressed = true;
            while (aWebBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }
        public void WaitBrowser(WebBrowser aWebBrowser)
        {
            aWebBrowser.ScriptErrorsSuppressed = true;
            while (aWebBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }
        public void CycleModels(int Car_ID)
        {
            WebBrowser testWb = new WebBrowser();
            var MarkSelect = webTest.Document.GetElementById("search_brand_id"); // get the mark 
            var AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            var ModelSelect = webTest.Document.GetElementById("model_id"); // get model select
            mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            var btnFind = webTest.Document.All.GetElementsByName("btnSearch")[0];
            SetBrowserElements SetElements = delegate()
            {
                //after each change those elements must be reinitialized;
                MarkSelect = webTest.Document.GetElementById("search_brand_id"); // get the mark 
                AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
                ModelSelect = webTest.Document.GetElementById("model_id"); // get model select
                AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement;
                btnFind = webTest.Document.All.GetElementsByName("btnSearch")[0];
            };
            string menu = string.Empty;
            String sLink = String.Empty;

            string oldLink = webTest.Url.ToString();
            int NumberOfModels = AllModels.length;
            AllModels.selectedIndex = CurrentModel;

            int Index = 1;
            for (Index = 1; Index < NumberOfModels; Index++)
            {
                AllModels.selectedIndex = Index;
                string[] ModelData = ModelNameExtract(ModelSelect, Index);
                btnFind.InvokeMember("Click");
                while (oldLink == webTest.Url.ToString())
                {
                    Application.DoEvents();
                }

                WaitBrowser(webTest);
                SetElements();
                string modeltxt = AllModels.innerHTML;

                string currentLink = webTest.Url.ToString();
                LoadSite(testWb, currentLink);
                LoadSite(webTest, oldLink);

                sLink = testWb.Url.ToString();
                SetElements();
                SearchPartPage(testWb);
                
                string YearManuf = string.Empty;
                if (ModelData.Length > 1) 
                   YearManuf = ModelData[1].Substring(0, 4);
                else 
                    YearManuf = null;
                int Model_ID = ModelIDByCarAndModel(MarkSelect.Children[CurrentCar].InnerText, ModelData[0], YearManuf);
                SetElements();

                CurrentModel++;
                AllCars.selectedIndex = CurrentCar;
                MarkSelect.RaiseEvent("onChange");
                while (AllModels.length < 2)
                {
                    Application.DoEvents();
                }
                AllModels.selectedIndex = Index;
                SetElements();
            }

        }

        public void SearchPartPage(WebBrowser wbCurrentPage)
        {
            DateTime Now = DateTime.Now;
            List<string> NextLink = new List<string>();
            List<string> FoundLinks = new List<string>();
            var TableElem = wbCurrentPage.Document.GetElementById("search-result-table");
            WebClient webClient = new WebClient();
            string pageCont = webClient.DownloadString(wbCurrentPage.Url.ToString());
            HtmlAgilityPack.HtmlDocument CurrentDoc = new HtmlAgilityPack.HtmlDocument();
            CurrentDoc.LoadHtml(pageCont);
           
            foreach (HtmlElement row in TableElem.Children)
            {
                FoundLinks = FindLinks(row.InnerHtml);
                if (FoundLinks.Count != 0)
                {
                    foreach (var Link in FoundLinks)
                    {
                        partS_LINKTableAdapter1.Insert(GEN_ID("PART_LINKS"), GEN_ID("PART_ID"), Constants.AutoBimLink + Link, DateTime.Now);
                    }
                }
                var NextPage = wbCurrentPage.Document.GetElementById("pagination");
                var hrefs = NextPage.GetElementsByTagName("a");
                foreach (HtmlElement Links in hrefs)
                {
                    if (Links.InnerText.Contains("следваща"))
                       NextLink = FindLinks(Links.OuterHtml);
                }

            }  
        }

        public List<string> FindLinks(string TableTxt)
        {
            MatchCollection m1 = Regex.Matches(TableTxt, @"(<A.*?>.*?</A>)",
                                 RegexOptions.Singleline);
            List<string> LinkList = new List<string>();
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                                        RegexOptions.Singleline);
                if (m2.Success)
                {
                   if (LinkList.Contains(m2.Groups[1].Value) != true)
                      LinkList.Add(m2.Groups[1].Value);
                }
            }

            return LinkList;

        }

        public int ModelIDByCarAndModel(String CarName, String ModelName, String YearStart)
        {
            String Car_ID = string.Empty;
            String YearParam = String.Empty;
            YearParam = YearStart != null ? "= '" + YearStart + "'" : "IS NULL";
            carShopDataSet1.Cars.Select("car_model = '" + CarName + "'");
            DataRow[] drCarID = carShopDataSet1.Cars.Select("car_model = '" + CarName + "'");
            Car_ID = drCarID[0]["CAR_ID"].ToString();

            String SearchModelQry = "CAR_ID = '" + Car_ID + "' AND MODEL_NAME = '" + ModelName + "' AND YEAR_MANUF " + YearParam;
            DataRow[] ModelID = carShopDataSet1.Models.Select(SearchModelQry);
            return int.Parse(ModelID[0]["MODEL_ID"].ToString());
        }

        public string[] ModelNameExtract(HtmlElement heModelElem, int IndexElement)
        {
            string ModelName = heModelElem.Children[IndexElement].InnerText;
            string[] Separator = { " от ", " до " };
            string[] ModelData = ModelName.Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            return ModelData;
        }



        public void SavePartLink(String sPartUrl)
        {

        }
        public async void CycleMarksAndGetModels()
        {
            carsTableAdapter1.Fill(carShopDataSet1.Cars);
            modelsTableAdapter1.Fill(carShopDataSet1.Models);
            int index = 1;
            var MarkSelect = webTest.Document.GetElementById("search_brand_id"); // get the mark 
            var ModelSelect = webTest.Document.GetElementById("model_id"); // get model select
            mshtml.HTMLSelectElement AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            string menu = string.Empty;
            string modelMenu = string.Empty;
            int numberOfCars = AllCars.length;
            CurrentModel = index;
            for (index = 1; index < numberOfCars; index++)
            {
                MarkSelect = webTest.Document.GetElementById("search_brand_id"); // get the mark 
                ModelSelect = webTest.Document.GetElementById("model_id"); // get model select
                AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
                AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
                CurrentCar = index;

                AllCars.selectedIndex = index;
                MarkSelect.RaiseEvent("onChange");
                while (AllModels.length < 2)
                {
                    Application.DoEvents();
                }
                HtmlElement OptCarMark = MarkSelect.Children[index];
                await Task.Delay(100);
                menu = OptCarMark.InnerHtml;
                //modelMenu = AllModels.innerText;
                CycleModels(index);//
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CategorySearcher CategoryWriter = new CategorySearcher();
            CategoryWriter.GetAllCategories();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private int GEN_ID(String sGenerator)
        {
            using (SqlConnection conn = new SqlConnection(carsTableAdapter1.Connection.ConnectionString.ToString()))
            using (SqlCommand cmd = new SqlCommand("dbo.SP_GEN_ID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // set up the parameters
                cmd.Parameters.Add("@GENERATOR_NAME", SqlDbType.VarChar, 32);
                cmd.Parameters.Add("@GENERATOR_STEP", SqlDbType.Int);
                cmd.Parameters.Add("@NEW_VALUE", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@GENERATOR_NAME"].Value = sGenerator;
                cmd.Parameters["@GENERATOR_STEP"].Value = 1;
                // open connection and execute stored procedure
                conn.Open();
                cmd.ExecuteNonQuery();

                // read output value from @NewId
                int GenValue = Convert.ToInt32(cmd.Parameters["@NEW_VALUE"].Value);
                conn.Close();
                return GenValue;
            }

        } //bla
    }
}

