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
using mshtml;

namespace Car
{
    class CategorySearcher
    {
        WebBrowser wbTest;
        CarShopDataSet DSCarShop;
        public delegate void SetBrowserElements();
        public CategorySearcher()
        {
            this.wbTest = new WebBrowser();
            this.DSCarShop = new CarShopDataSet();
            this.DSCarShop.InitAdapters();
        }

        public void InitSiteConnection()
        {
            wbTest.Url = new Uri("http://www.avto.bim.bg/tursene/pt1");
            wbTest.ScriptErrorsSuppressed = true;
            while (wbTest.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        public void GetAllCategories()
        {
            InitSiteConnection();
            var MainCategory = wbTest.Document.GetElementById(Constants.MainCatID);
            var SubCategoryID = wbTest.Document.GetElementById(Constants.SubCategID);
            HTMLSelectElement AllMainCategories = MainCategory.DomElement as HTMLSelectElement;
            HTMLSelectElement AllSubCategories = SubCategoryID.DomElement as HTMLSelectElement;
            for(int i = 0; i < AllMainCategories.length; i++)
            {
                AllMainCategories.selectedIndex = i + 1;
                string test = MainCategory.InnerText;
                /* if (OptionRow.InnerText != Constants.MainCatBeginStr)
                 {   int P_CategoryID = DSCarShop.GEN_ID("P_CATEGORY");
                     DSCarShop.ProvCategoryAdapter.Insert(P_CategoryID, OptionRow.InnerText, Constants.AutoBim, null);
                     GetSubCategory(P_CategoryID, OptionRow.InnerText);
                 }*/
            }     
        }
        private void GetSubCategory(int CategoryID, string CategoryName)
        {
            var SubCategoryID = wbTest.Document.GetElementById(Constants.SubCategID);
            foreach (HtmlElement SubOptionRow in SubCategoryID.Children)
               if ((SubOptionRow.InnerText != Constants.SubCatBeginStr) && (SubOptionRow.InnerText != CategoryName))
                    DSCarShop.SubCategoryAdapter.Insert(DSCarShop.GEN_ID("S_CATEGORY"), CategoryID, SubOptionRow.InnerText);
        }

     
    }
}
