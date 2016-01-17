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
using HtmlAgilityPack;
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
            DSCarShop.LoadPartsLink();
            foreach (DataRow Part in DSCarShop.PARTS_LINK.Rows)
            {
                string PartUrl = Part["URL"].ToString();
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
                var MainDivElem = wbTest.Document.GetElementById("main");
                string DetailsClassName = "product-shop margin-details-infobox";
                HtmlElement PriceElem = wbTest.Document.GetElementById("breadcrumb");
                string ProductCode = string.Empty;
                string OE = string.Empty;
                var Spans = wbTest.Document.GetElementsByTagName("span");
                double? Price = 0.0;
                string Description = string.Empty;
                string PartManuf = string.Empty;
                foreach (HtmlElement AllElems in Spans)
                {
                    if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("sku"))
                        ProductCode = AllElems.InnerText;
                    if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("#manufacture_info_"))
                        PartManuf = AllElems.InnerText;
                    if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("mpn"))
                        OE = AllElems.InnerText;
                    if (AllElems.OuterHtml != null && !AllElems.OuterHtml.Contains("price_for_us") && AllElems.OuterHtml.Contains("price"))
                    {
                        Price = Convert.ToDouble(AllElems.InnerText.Replace(".", ","));
                        break;
                    }


                }
                var Paragraphs = wbTest.Document.GetElementsByTagName("p");
                foreach (HtmlElement Elems in Paragraphs)
                    if (Elems.OuterHtml != null && Elems.OuterHtml.Contains("description"))
                        Description = Elems.InnerText;
                DSCarShop.PartsTblAdapter.Insert(DSCarShop.GEN_ID("Parts"), PartName, Price, Description, PartManuf, CarMarkID, ModelID, 1);
            }
        }
    }
}
