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
using Car;
namespace PartCrawler
{
    class PartCrawler
    {
        CarShopDataSet DSCarShop;
        
        public WebBrowser wbTest { get; set; }
        public PartCrawler()
        {
            this.wbTest = new WebBrowser();
            this.DSCarShop = new CarShopDataSet();
            this.DSCarShop.InitAdapters();
        }

        public void GetAllPagesInfo()
        {
            string PartUrl = "http://www.avto.bim.bg/Amortisior-za-bagajnik-lqv=desen-za-ALFA-ROMEO-145-ot-1995-do-1998_p49556m1.html";
            int PartID = 1;
            CommonFuncs.LoadSite(wbTest, PartUrl);
            var CategoryDiv = wbTest.Document.GetElementById("breadcrumb");
            var MarkSelect = wbTest.Document.GetElementById("mini_brand_id");
            var ModelSelect = wbTest.Document.GetElementById("mini_model_id");
            var PartTitleElem = wbTest.Document.GetElementById("part-details-h1");
            var ManufactElem = wbTest.Document.GetElementById("#manufacture_info_119");
            HTMLSelectElement SelectMark = MarkSelect.DomElement as HTMLSelectElement;
            HTMLSelectElement SelectModel = ModelSelect.DomElement as HTMLSelectElement;
            string MarkName = MarkSelect.Children[SelectMark.selectedIndex].InnerText;
            string ModelName = ModelSelect.Children[SelectModel.selectedIndex].InnerText;
            HtmlElement CategoryAnch = CategoryDiv.Children[4];
            string Link = CategoryAnch.InnerText;
            string ReplaceString = " за " + MarkName + " " + ModelName;
            string Category = Link.Replace(ReplaceString, "");
            int CarMarkID = DSCarShop.GetCarIDByName(MarkName);
            int SubCategoryName = DSCarShop.GetSubCategIDByName(Category);
            string[] ExtractedModel = CommonFuncs.ModelNameExtract(ModelSelect, SelectModel.selectedIndex);
            int ModelID = DSCarShop.GetModelIDByModelInfo(CarMarkID, ExtractedModel);
            string PartName = PartTitleElem.InnerText.Replace(ReplaceString, "");
            string PartManuf = ManufactElem.InnerText.Replace("Производител: ", "");
            var MainDivElem = wbTest.Document.GetElementById("main")

        }

    }
}
