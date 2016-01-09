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
    }
}
