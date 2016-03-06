using System;
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
            FormClients FrmClients = new FormClients();
            FrmClients.MdiParent = this;
            FrmClients.Dock = DockStyle.Fill;
            FrmClients.Show();
        }
    }
}
