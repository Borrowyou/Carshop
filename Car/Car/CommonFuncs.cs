﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public static class CommonFuncs
    {
        public static void WaitBrowser(WebBrowser aWebBrowser, string OldUrl)
        {
            aWebBrowser.ScriptErrorsSuppressed = true;
            while ((aWebBrowser.ReadyState != WebBrowserReadyState.Complete) && (OldUrl == aWebBrowser.Url.ToString()))
            {
                Application.DoEvents();
            }
        }
        public static void LoadSite(WebBrowser aWebBrowser, string sUrl)
        {
            aWebBrowser.Url = new Uri(sUrl);
            aWebBrowser.ScriptErrorsSuppressed = true;
            while (aWebBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        public static string[] ModelNameExtract(HtmlElement heModelElem, int IndexElement)
        {
            string ModelName = heModelElem.Children[IndexElement].InnerText;
            string[] Separator = { " от ", " до " };
            string[] ModelData = ModelName.Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            return ModelData;
        }

    }
}
