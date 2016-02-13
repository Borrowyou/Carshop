using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void partsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PartManagement.FormParts PartsForm = new PartManagement.FormParts();
            PartsForm.TopLevel = false;
            PartsForm.Parent = this;
            PartsForm.Show();
            
        }

    }
}
