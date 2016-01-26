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
        
        //public WebBrowser wbTest { get; set; }
        public PartCrawler()
        {
            ///this.wbTest = new WebBrowser();
            this.DSCarShop = new CarShopDataSet();
            this.DSCarShop.InitAdapters();
        }
        public void AGetAllPagesInfo()
        {
           /* DSCarShop.LoadPartsLink();
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
                int SubCategoryID = DSCarShop.GetSubCategIDByName(Category);
                string[] ExtractedModel = CommonFuncs.ModelNameExtract(ModelSelect, SelectModel.selectedIndex);
                int ModelID = DSCarShop.GetModelIDByModelInfo(CarMarkID, ExtractedModel);
                string PartName = PartTitleElem.InnerText.Replace(ReplaceString, "");
                var MainDivElem = wbTest.Document.GetElementById("main");
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
                    if (AllElems.OuterHtml != null && !AllElems.OuterHtml.Contains("price_for_us") && AllElems.OuterHtml.Contains("itemprop=\"price\""))
                    {
                        Price = Convert.ToDouble(AllElems.InnerText.Replace(".", ","));
                        break;
                    }


                }
                var Paragraphs = wbTest.Document.GetElementsByTagName("p");
                foreach (HtmlElement Elems in Paragraphs)
                    if (Elems.OuterHtml != null && Elems.OuterHtml.Contains("description"))
                        Description = Elems.InnerText;
                DSCarShop.PartsTblAdapter.Insert(DSCarShop.GEN_ID("Parts"), PartName, Price, Description, PartManuf, CarMarkID, ModelID, SubCategoryID);
            }*/
        }
        public void GetAllPagesInfo()
        {
            DSCarShop.LoadPartsLink();
            foreach (DataRow Part in DSCarShop.PARTS_LINK.Rows)
            {
                string PartUrl = Part["URL"].ToString();
                HtmlWeb wbClient = new HtmlWeb();
                wbClient.OverrideEncoding = Encoding.UTF8;
                HtmlAgilityPack.HtmlDocument CurrentDoc = new HtmlAgilityPack.HtmlDocument();
                CurrentDoc = wbClient.Load(PartUrl);
                int PartID = 1;
                var CategoryDiv = CurrentDoc.GetElementbyId("breadcrumb");
                var MarkSelect = CurrentDoc.GetElementbyId("mini_brand_id");
                var ModelSelect = CurrentDoc.GetElementbyId("mini_model_id");
                var PartTitleElem = CurrentDoc.GetElementbyId("part-details-h1");
                HtmlNode MarkAnch = CategoryDiv.ChildNodes[4];
                HtmlNode ModelAnch = CategoryDiv.ChildNodes[6];
                
                string MarkName = MarkAnch.InnerText.Replace("Авточасти за ", "");
                string ModelAnchTxt = ModelAnch.InnerText.Replace("\r", "").Replace("\n", "");
                string ModelName = ModelAnchTxt.Replace("Авточасти  за ", "").Replace(MarkName + " ", "");
                HtmlNode CategoryAnch = CategoryDiv.ChildNodes[8];
                
                string Link = CategoryAnch.InnerText;
                string ReplaceString = " за " + MarkName + " " + ModelName;
                string Category = Link.Replace(ReplaceString, "");
                int CarMarkID = DSCarShop.GetCarIDByName(MarkName);
                int SubCategoryID = DSCarShop.GetSubCategIDByName(Category);
                string[] ExtractedModel = CommonFuncs.ModelNameExtract(ModelName);
                int ModelID = DSCarShop.GetModelIDByModelInfo(CarMarkID, ExtractedModel);
                string PartName = PartTitleElem.InnerText.Replace(ReplaceString, "");
                var MainDivElem = CurrentDoc.GetElementbyId("main");
                var PriceElem = CurrentDoc.GetElementbyId("breadcrumb");
                string ProductCode = string.Empty;
                string OE = string.Empty;
                var Spans = CurrentDoc.DocumentNode.SelectNodes("//span");
                double? Price = 0.0;
                string Description = string.Empty;
                string PartManuf = string.Empty;
                foreach (HtmlNode AllElems in Spans)
                {
                    if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("sku"))
                        ProductCode = AllElems.InnerText;
                    if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("#manufacture_info_"))
                        PartManuf = AllElems.InnerText;
                    if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("mpn"))
                        OE = AllElems.InnerText;
                    /*if (AllElems.OuterHtml != null && !AllElems.OuterHtml.Contains("price_for_us") && AllElems.OuterHtml.Contains("\"price\"")
                        && AllElems.OuterHtml.Contains("itemprop"))
                    {
                        Price = Convert.ToDouble(AllElems.InnerText.Replace(".", ","));
                        break;
                    }*/


                }
                var PriceNode = CurrentDoc.DocumentNode.SelectNodes("//span[@itemprop='price']");
                if (PriceNode != null)
                    Price = Convert.ToDouble(PriceNode[0].InnerText.Replace(".", ","));
                var Paragraphs = CurrentDoc.DocumentNode.SelectNodes("//p");
                foreach (HtmlNode Elems in Paragraphs)
                    if (Elems.OuterHtml != null && Elems.OuterHtml.Contains("description"))
                        Description = Elems.InnerText;
                DSCarShop.PartsTblAdapter.Insert(DSCarShop.GEN_ID("Parts"), PartName, Price, Description, PartManuf, CarMarkID, ModelID, SubCategoryID);
            }
        }
    }
}
