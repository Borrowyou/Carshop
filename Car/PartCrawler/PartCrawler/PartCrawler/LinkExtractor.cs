using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using mshtml;
using System.Net;
using HtmlAgilityPack;
using Car;

namespace PartCrawler
{
    class LinkExtractor
    {
        CarShopDataSet DSCarShop;
        int threadIndex;
        private ManualResetEvent doneEvent;
        string URL;
        public WebBrowser wbBrowser { get; set; }
        LCommonFuncs Common;

        public LinkExtractor(string sURL, ManualResetEvent EdoneEvent)
        {
            DSCarShop = new CarShopDataSet();
            DSCarShop.InitAdapters();
            wbBrowser = new WebBrowser();
            doneEvent = EdoneEvent;
            threadIndex = Thread.CurrentThread.ManagedThreadId;
            URL = sURL;
            Common = new LCommonFuncs();
        }
        public void SearchPartPage()
        {
            HtmlWeb  wbClient = new HtmlWeb ();
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
                TableElem = CurrentDoc.GetElementbyId("search-result-table");
                NextPage = CurrentDoc.GetElementbyId("pagination");
                foreach (HtmlNode row in TableElem.ChildNodes)
                {
                    FoundLinks = CommonFuncs.FindLinksinNode(row.InnerHtml);
                    if (FoundLinks.Count != 0)
                        foreach (var Link in FoundLinks)
                            DSCarShop.PartLinkTblAdapter.Insert(DSCarShop.GEN_ID("PART_LINKS"), DSCarShop.GEN_ID("PART_ID"), Constants.AutoBimLink + Link, DateTime.Now, threadIndex);

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
        public void ASearchPartPage()
        {
            string wburl = string.Empty;
            if (wbBrowser.Url != null)
                wburl  = wbBrowser.Url.ToString();
            wbBrowser.Url = new Uri(URL);
            while (wburl != URL)
            {
                if (wbBrowser.Url != null)
                    wburl = wbBrowser.Url.ToString();
            }
            Common.LoadSite(wbBrowser, URL);
            DateTime Now = DateTime.Now;
            List<string> NextLink = new List<string>();
            List<string> FoundLinks = new List<string>();
            List<string> FetchedLinks = new List<string>();
            var TableElem = wbBrowser.Document.GetElementById("search-result-table");
            var NextPage = wbBrowser.Document.GetElementById("pagination");
            string LastPageNavLink = string.Empty;
            string oldLink = string.Empty;
            for (int ind = 0; ind < NextPage.Children.Count; ind++)
            {
                HtmlElement elem = NextPage.Children[ind];
                if (elem.OuterHtml.Contains("Отвори последна страница"))
                    LastPageNavLink = Common.FindLinks(elem.OuterHtml)[0].ToString();
            }
            bool KeepCrawl = true;
            while (TableElem != null && !FetchedLinks.Contains(wbBrowser.Url.ToString()) && KeepCrawl)
            {
                TableElem = wbBrowser.Document.GetElementById("search-result-table");
                NextPage = wbBrowser.Document.GetElementById("pagination");
                foreach (HtmlElement row in TableElem.Children)
                {
                    FoundLinks = Common.FindLinks(row.InnerHtml);
                    if (FoundLinks.Count != 0)
                        foreach (var Link in FoundLinks)
                            DSCarShop.PartLinkTblAdapter.Insert(DSCarShop.GEN_ID("PART_LINKS"), DSCarShop.GEN_ID("PART_ID"), Constants.AutoBimLink + Link, DateTime.Now, threadIndex);

                }
                var hrefs = NextPage.GetElementsByTagName("a");
                string NextUrl = string.Empty;
                foreach (HtmlElement Links in hrefs)
                    if (Links.InnerText.Contains("следваща"))
                    {
                        NextLink = Common.FindLinks(Links.OuterHtml);
                        if (NextLink.Count > 0)
                            NextUrl = NextLink[0];
                    }
                KeepCrawl = NextLink.Count > 0;
                oldLink = wbBrowser.Url.ToString();
                if (wbBrowser.Url != null)
                    wburl = wbBrowser.Url.ToString();
                wbBrowser.Url = new Uri(Constants.AutoBimLink + NextUrl);
                while (wburl != URL)
                { 
                                    if (wbBrowser.Url != null)
                    wburl = wbBrowser.Url.ToString();
                }
                FetchedLinks.Add(oldLink);
            }

        }

        public void runBrowserThread()
        {

        }

        public void ThreadPoolCallback(Object threadContext)
        {
            threadIndex = (int)threadContext;
            SearchPartPage();
        }

    }
}
