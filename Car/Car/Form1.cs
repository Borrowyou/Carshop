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
    public partial class Form1 : Form
    {
        CarSearch CarSearcher;
        ModelSearcher ModelSrch;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModelSrch = new ModelSearcher();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarSearcher = new CarSearch();
            this.wbTest = CarSearcher.PwbTest;
            CarSearcher.InitSiteConnection();
            this.wbTest = CarSearcher.PwbTest;
            wbTest.Refresh();
            CarSearcher.GetCarMarks();
            CarSearcher.SaveCarMarksToDB();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            ModelSrch.InitSiteConnection();
            ModelSrch.CycleMarksAndGetModels();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ModelSrch.SaveMaodelsToDB();
        }

    }
}


