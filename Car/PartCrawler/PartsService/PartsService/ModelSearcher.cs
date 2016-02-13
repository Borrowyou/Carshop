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
using PartsService;
using CommonFuncsU;


namespace PartCrawler
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
            get
            {
                return this.wbTest;
            }
            set
            {
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

        public void CycleMarksAndGetModels()
        {
            try
            {
                InitSiteConnection();
                var MarkSelect = wbTest.Document.GetElementById("search_brand_id"); // get the mark 
                var ModelSelect = wbTest.Document.GetElementById("model_id"); // get model select
                mshtml.HTMLSelectElement AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
                mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
                for (int i = 1; i < AllCars.length; i++)
                {
                    AllCars.selectedIndex = i;
                    CommonFuncs.InvokeOnChange(MarkSelect, ModelSelect);
                    int CarID = DSCarShop.GetOrInsertCarIDByName(MarkSelect.Children[i].InnerText);
                    for (int k = 1; k < AllModels.length; k++)
                    {
                        string[] ModelData = CommonFuncs.ModelNameExtract(ModelSelect, k);
                        int ModelID = DSCarShop.GEN_ID("Models");
                        int? YearManuf = CommonFuncs.StringToNInt(ModelData[1]);
                        int? YearStop = CommonFuncs.StringToNInt(ModelData[2]);
                        DSCarShop.GetOrInsertModelIDByName(CarID, ModelData);
                        // DSCarShop.ModelsTblAdapter.Insert(ModelID, ModelData[0], YearManuf, YearStop, CarID, null);
                    }
                }
            }
            catch (Exception EX)
            {
                Logger.Error(EX, "DB"); 
            }
        }
    }
}
