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
    class CarSearch
    {
       WebBrowser wbTest;

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
    }
}
