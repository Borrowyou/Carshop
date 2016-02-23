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
using PartsService;
using CommonFuncsU;
using ResStringU;

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
            Logger.Info("Part Crawler class created", "Parts");
        }

        public void GetAllPagesInfo()
        {
            bool k = true;
            while(k)
            {
                DSCarShop.LoadPartsLink();

                foreach (DataRow Part in DSCarShop.PARTS_LINK.Rows)
                {
                    Logger.Info("Getting parts" + Part["URL"].ToString(), "Parts");
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
                    string imgLink = string.Empty;
                    foreach (HtmlNode AllElems in Spans)
                    {
                        if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("sku"))
                            ProductCode = AllElems.InnerText;
                        if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("#manufacture_info_"))
                            PartManuf = AllElems.InnerText;
                        if (AllElems.OuterHtml != null && AllElems.OuterHtml.Contains("mpn"))
                            OE = AllElems.InnerText;
                        
                    }
                    var ImgNode = CurrentDoc.DocumentNode.SelectNodes("//img[@id='mainImage']");
                    imgLink = CommonFuncs.FindImgSrcNode(ImgNode[0]);
                    var PriceNode = CurrentDoc.DocumentNode.SelectNodes("//span[@itemprop='price']");
                    if (PriceNode != null)
                        Price = Convert.ToDouble(PriceNode[0].InnerText.Replace(".", ","));
                    var Paragraphs = CurrentDoc.DocumentNode.SelectNodes("//p");
                    foreach (HtmlNode Elems in Paragraphs)
                        if (Elems.OuterHtml != null && Elems.OuterHtml.Contains("description"))
                            Description = Elems.InnerText;
                    byte[] PartImg;
                    using (var client = new WebClient())
                    {
                        PartImg =  client.DownloadData(Constants.AutoBimLink + imgLink);
                    }

                    if (Price > 0)
                    {
                        PartID = DSCarShop.GEN_ID("Parts");
                        DSCarShop.PartsTblAdapter.Insert(PartID, PartName, Price, Description, PartManuf, CarMarkID, ModelID, SubCategoryID, PartImg);
                        Part["PART_ID"] = PartID;
                        Part["LAST_UPDATE"] = DateTime.Now;

                        DSCarShop.PartLinkTblAdapter.Update(DSCarShop.PARTS_LINK);
                    }

                }
            }
        }

    }
}
