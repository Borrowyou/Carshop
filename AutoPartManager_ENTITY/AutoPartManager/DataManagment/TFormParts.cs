﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManagment
{
    public partial class TFormParts : Form
    {
        public TFormParts()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TFormSearchParts FormSearchParts = new TFormSearchParts();
            FormSearchParts.MdiParent = this;
            FormSearchParts.Dock = DockStyle.Fill;
            FormSearchParts.Show();
        }
    }
}