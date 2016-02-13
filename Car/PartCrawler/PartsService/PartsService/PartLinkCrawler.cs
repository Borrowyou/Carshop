using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using mshtml;
using HtmlAgilityPack;
using PartsService;
using CommonFuncsU;
using ResStringU;
namespace PartCrawler
{
    class PartLinkCrawler
    {
             
        CarShopDataSet DSCarShop;
        public delegate void SetBrowserElements();

        public WebBrowser wbBrowser { get; set; }
        public PartLinkCrawler()
        {
            wbBrowser = new WebBrowser();
            DSCarShop = new CarShopDataSet();
            DSCarShop.InitAdapters();
        }

        public void PartAndModel()
        {
            CommonFuncs.LoadSite(wbBrowser, "http://www.avto.bim.bg/tursene/pt1");
            var MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
            var ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
            HTMLSelectElement AllCars = MarkSelect.DomElement as HTMLSelectElement; // all items in mark select
            HTMLSelectElement AllModels = ModelSelect.DomElement as HTMLSelectElement; // all items in mark select
            for (int i = 1; i < AllCars.length; i++)
            {
                MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
                ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
                AllCars = MarkSelect.DomElement as HTMLSelectElement; // all items in mark select
                AllModels = ModelSelect.DomElement as HTMLSelectElement; // all items in mark select       
                AllCars.selectedIndex = i;

                MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
                ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
                AllCars = MarkSelect.DomElement as HTMLSelectElement; // all items in mark select
                AllModels = ModelSelect.DomElement as HTMLSelectElement; // all items in mark select

            }
        }


        public void GetAllPartLinks()
        {
            CommonFuncs.LoadSite(wbBrowser, "http://www.avto.bim.bg/tursene/pt1");
            var MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
            var ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
            HTMLSelectElement AllCars = MarkSelect.DomElement as HTMLSelectElement; // all items in mark select
            HTMLSelectElement AllModels = ModelSelect.DomElement as HTMLSelectElement; // all items in mark select
            var btnFind = wbBrowser.Document.All.GetElementsByName("btnSearch")[0];
            string OldWBLink = wbBrowser.Url.ToString();
            for (int i = 1; i < AllCars.length; i++)
            {

                MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
                ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
                AllCars = MarkSelect.DomElement as HTMLSelectElement; // all items in mark select
                AllModels = ModelSelect.DomElement as HTMLSelectElement; // all items in mark select       
                AllCars.selectedIndex = i;
                CommonFuncs.InvokeOnChange(MarkSelect, ModelSelect);
                //after new page have loaded we must set the elements again
                CycleAndSelectModels();
                MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
                ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
                AllCars = MarkSelect.DomElement as HTMLSelectElement; // all items in mark select
                AllModels = ModelSelect.DomElement as HTMLSelectElement; // all items in mark select

            }
            
        }
        public void CycleAndSelectModels()
        {
            var MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
            var AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            var ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
            HTMLSelectElement AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
            var btnFind = wbBrowser.Document.All.GetElementsByName("btnSearch")[0];
            int NumberOfThreads = 0;
            SetBrowserElements SetElements = delegate()
            {
                MarkSelect = wbBrowser.Document.GetElementById("search_brand_id"); // get the mark 
                AllCars = MarkSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
                ModelSelect = wbBrowser.Document.GetElementById("model_id"); // get model select
                AllModels = ModelSelect.DomElement as mshtml.HTMLSelectElement; // all items in mark select
                btnFind = wbBrowser.Document.All.GetElementsByName("btnSearch")[0];        
            };
            int CurrentAllCar = AllCars.selectedIndex;
            string OldWBLink = wbBrowser.Url.ToString();
            for (int Index = 1; Index < AllModels.length; Index++)
            {

                AllModels.selectedIndex = Index;
                string[] ModelData = CommonFuncs.ModelNameExtract(ModelSelect, Index);
                CommonFuncs.InvokeOnClick(btnFind, wbBrowser); // click the button find
                CommonFuncs.WaitBrowser(wbBrowser);
                
                //after new page have loaded we must set the elements again
                SetElements();
                string CurrentLink = wbBrowser.Url.ToString();
                CSearchPartPage(CurrentLink);
                CommonFuncs.LoadSite(wbBrowser, OldWBLink);
                SetElements();
                AllCars.selectedIndex = CurrentAllCar;
                CommonFuncs.InvokeOnChange(MarkSelect, ModelSelect);
                AllModels.selectedIndex = Index;
                SetElements();

            }

        }

        public void CSearchPartPage(string URL)
        {
            HtmlWeb wbClient = new HtmlWeb();
            wbClient.OverrideEncoding = Encoding.UTF8;
            HtmlAgilityPack.HtmlDocument CurrentDoc = new HtmlAgilityPack.HtmlDocument();
            CurrentDoc = wbClient.Load(URL);
            DateTime Now = DateTime.Now;
            List<string> NextLink = new List<string>();
            List<string> FoundLinks = new List<string>();
            List<string> FetchedLinks = new List<string>();
            var TableElem = CurrentDoc.GetElementbyId("search-result-table");
            //GetElementById("search-result-table");
            var NextPage = CurrentDoc.GetElementbyId("pagination");
            string LastPageNavLink = string.Empty;
            string oldLink = string.Empty;
            string NewUrl = URL;
            for (int ind = 0; ind < NextPage.ChildNodes.Count; ind++)
            {
                var elem = NextPage.ChildNodes[ind];
                if (elem.OuterHtml.Contains("Отвори последна страница"))
                    LastPageNavLink = CommonFuncs.FindLinksinNode(elem.OuterHtml)[0].ToString();
            }

            bool KeepCrawl = true;
            while (TableElem != null && !FetchedLinks.Contains(NewUrl) && KeepCrawl)
            {
                if (oldLink == "")
                    oldLink = URL;
                else
                    oldLink = NewUrl;
                TableElem = CurrentDoc.GetElementbyId("search-result-table");
                NextPage = CurrentDoc.GetElementbyId("pagination");
                foreach (HtmlNode row in TableElem.ChildNodes)
                {
                    FoundLinks = CommonFuncs.FindLinksinNode(row.InnerHtml);
                    if (FoundLinks.Count != 0)
                        foreach (var Link in FoundLinks)
                            DSCarShop.PartLinkTblAdapter.Insert(DSCarShop.GEN_ID("PART_LINKS"), null, Constants.AutoBimLink + Link, DateTime.Now, 1);

                }
                var hrefs = NextPage.Descendants("a");
                string NextUrl = string.Empty;
                foreach (HtmlNode Links in hrefs)
                    if (Links.InnerText.Contains("следваща"))
                    {
                        NextLink = CommonFuncs.FindLinksinNode(Links.OuterHtml);
                        if (NextLink.Count > 0)
                            NextUrl = NextLink[0];
                    }
                KeepCrawl = NextLink.Count > 0;
                
                NewUrl = Constants.AutoBimLink + NextUrl;
                CurrentDoc = wbClient.Load(NewUrl);
                FetchedLinks.Add(oldLink);
            }

        }
        public void SearchPartPage(WebBrowser wbCurrentPage)
        {
            DateTime Now = DateTime.Now;
            List<string> NextLink = new List<string>();
            List<string> FoundLinks = new List<string>();
            List<string> FetchedLinks = new List<string>();
            var TableElem = wbCurrentPage.Document.GetElementById("search-result-table");
            var NextPage = wbCurrentPage.Document.GetElementById("pagination");
            string LastPageNavLink = string.Empty;
            string oldLink = string.Empty;
            for (int ind = 0; ind < NextPage.Children.Count; ind++)
            {
                HtmlElement elem = NextPage.Children[ind];
                if (elem.OuterHtml.Contains("Отвори последна страница"))
                    LastPageNavLink = CommonFuncs.FindLinks(elem.OuterHtml)[0].ToString();
            }
            bool KeepCrawl = true;
            while (TableElem != null && !FetchedLinks.Contains(wbCurrentPage.Url.ToString()) && KeepCrawl)
            {
                TableElem = wbCurrentPage.Document.GetElementById("search-result-table");
                NextPage = wbCurrentPage.Document.GetElementById("pagination");
                foreach (HtmlElement row in TableElem.Children)
                {
                    FoundLinks = CommonFuncs.FindLinks(row.InnerHtml);
                    if (FoundLinks.Count != 0)
                        foreach (var Link in FoundLinks)
                            DSCarShop.PartLinkTblAdapter.Insert(DSCarShop.GEN_ID("PART_LINKS"), DSCarShop.GEN_ID("PART_ID"), Constants.AutoBimLink + Link, DateTime.Now, 0);
 
                }
                var hrefs = NextPage.GetElementsByTagName("a");
                string NextUrl = string.Empty;
                foreach (HtmlElement Links in hrefs)
                    if (Links.InnerText.Contains("следваща"))
                    {
                        NextLink = CommonFuncs.FindLinks(Links.OuterHtml);
                        if (NextLink.Count > 0)
                            NextUrl = NextLink[0];
                    }
                KeepCrawl = NextLink.Count > 0;
                oldLink = wbCurrentPage.Url.ToString();
                CommonFuncs.LoadSite(wbCurrentPage, Constants.AutoBimLink + NextUrl);
                FetchedLinks.Add(oldLink);
            }
            
        }

    }
}
