using System;
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
            string YearManuf = string.Empty;
            string YearStop = string.Empty;
            string[] Separator = { " от ", " до " };
            string[] ModelData = ModelName.Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            if (ModelData.Length > 1)
                YearManuf = ModelData[1].Substring(0, 4);
            else
                YearManuf = null;
            if (ModelData.Length > 2)
                YearStop = ModelData[2].Substring(0, 4);
            else
                YearStop = null;
            string[] ExtractedData = { ModelData[0], YearManuf, YearStop };
            return ExtractedData;
        }

        public static int? StringToNInt(string val)
        {
            int i;
            return int.TryParse(val, out i) ? (int?)i : null;
        }
        

    }
}
