﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

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
            try
            {
                aWebBrowser.Url = new Uri(sUrl);
                aWebBrowser.ScriptErrorsSuppressed = true;
                while (aWebBrowser.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
            }
            catch { }
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
        public static string[] ModelNameExtract(HtmlNode heModelElem, int IndexElement) 
        {
            string ModelName = heModelElem.ChildNodes[IndexElement].InnerText;
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

        public static string[] ModelNameExtract(string ModelTxt)
        {
            string ModelName = ModelTxt;
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

        public static void InvokeOnChange(HtmlElement MainElem, HtmlElement SubElement)
        {
            string OldInnerTxt = SubElement.InnerText;
            MainElem.RaiseEvent("onChange");
            while (OldInnerTxt == SubElement.InnerText)
            {
                Application.DoEvents();
            }
        }
        public static int? StringToNInt(string val)
        {
            int i;
            return int.TryParse(val, out i) ? (int?)i : null;
        }

        public static void InvokeOnClick(HtmlElement ElemToClick, WebBrowser wb)
        {
            string oldLink = wb.Url.ToString();
            ElemToClick.InvokeMember("Click");
            while (oldLink == wb.Url.ToString())
                Application.DoEvents();
        }

        public static void WaitBrowser(WebBrowser aWebBrowser)
        {
            aWebBrowser.ScriptErrorsSuppressed = true;
            while (aWebBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        public static  List<string> FindLinks(string TableTxt)
        {
            MatchCollection m1 = Regex.Matches(TableTxt, @"(<A.*?>.*?</A>)",
                                 RegexOptions.Singleline);
            List<string> LinkList = new List<string>();
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                                        RegexOptions.Singleline);
                if (m2.Success)
                {
                    if (LinkList.Contains(m2.Groups[1].Value) != true)
                        LinkList.Add(m2.Groups[1].Value);
                }
            }
            return LinkList;
        }


        public static List<string> FindLinksinNode(string TableTxt)
        {
            MatchCollection m1 = Regex.Matches(TableTxt, @"(<a.*?>.*?</a>)",
                                 RegexOptions.Singleline);
            List<string> LinkList = new List<string>();
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                Match m2 = Regex.Match(value, @"href=\'(.*?)\'",
                                        RegexOptions.Singleline);
                if (m2.Success)
                {
                    if (LinkList.Contains(m2.Groups[1].Value) != true)
                        LinkList.Add(m2.Groups[1].Value);
                }
            }
            return LinkList;
        }
        
    }
}