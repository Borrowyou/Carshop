using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PartCrawler
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartCrawler PartCrawl = new PartCrawler();
            PartCrawl.GetAllPagesInfo();
        }

        private void CrawlAllParts()
        { 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblWriteParts.Text = "Работи";

            PartLinkCrawler LinkCrawler = new PartLinkCrawler();
            //webBrowser1 = LinkCrawler.wbBrowser;
            LinkCrawler.GetAllPartLinks();

            lblWriteParts.Text = "Приключи";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWriteParts.Text = "Не работи";
            var th = new Thread(() =>
            {
                PartCrawler PartCrawl = new PartCrawler();
                for(;;)
                    PartCrawl.GetAllPagesInfo();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //webBrowser1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblWriteParts.Text = "Спрян";
        }
    }
}
