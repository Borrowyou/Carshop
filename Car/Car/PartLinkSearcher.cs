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
    class PartLinkSearcher
    {
        WebBrowser wbTest;
        CarShopDataSet DSCarShop;
        int Model_ID = 1;
        public PartLinkSearcher()
        {
            this.wbTest = new WebBrowser();

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
        public void LoadSite(WebBrowser aWebBrowser, string sUrl)
        {
            aWebBrowser.Url = new Uri(sUrl);
            aWebBrowser.ScriptErrorsSuppressed = true;
            while (aWebBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }
        public async void CycleModels(int Car_ID)
        {
            var ModelSelect = wbTest.Document.GetElementById("model_id"); // get model select
            mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            var btnFind = wbTest.Document.All.GetElementsByName("btnSearch")[0];
            string menu = string.Empty;
            String sLink = String.Empty;
            foreach (HtmlElement OptionMark in ModelSelect.Children)
            {
                if (OptionMark.InnerText != "---Модел---" && OptionMark.InnerText != "---Избери Модел---")
                {
                    while (wbTest.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    }
                    sLink = wbTest.Url.ToString();

                    btnFind.InvokeMember("Submit");
                    btnFind.InvokeMember("submit");
                    btnFind.InvokeMember("Click");
                    while (wbTest.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    }
                    await Task.Delay(100);

                }
            }
        }
        public void SavePartLink(String sPartUrl)
        {

        }
        public async void CycleMarksAndGetModels()
        {

            var MarkSelect = wbTest.Document.GetElementById("search_brand_id"); // get the mark 
            var ModelSelect = wbTest.Document.GetElementById("model_id"); // get model select
            mshtml.HTMLSelectElement AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            mshtml.HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            string menu = string.Empty;
            string modelMenu = string.Empty;
            for (int i = 1; i < AllCars.length; i++)
            {

                AllCars.selectedIndex = i;
                MarkSelect.RaiseEvent("onChange");
                while (AllModels.length < 2)
                {
                    Application.DoEvents();
                }
                HtmlElement OptCarMark = MarkSelect.Children[i];
                await Task.Delay(100);
                menu = OptCarMark.InnerHtml;
                modelMenu = AllModels.innerText;
                CycleModels(i);//
            }
                
            }
    } //bla
}

