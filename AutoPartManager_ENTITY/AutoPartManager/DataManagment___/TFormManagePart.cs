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
    public partial class TFormManagePart : Form
    {
        public TFormManagePart()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        public TFormManagePart(TPartsDataSet APartsDSet)
        {
            InitializeComponent();
            this.PartsDataSet = APartsDSet;
            PartBindSrc.DataSource = PartsDataSet;
            Dock = DockStyle.Fill;
        }


        private void TFormManagePart_Load(object sender, EventArgs e)
        {

        }
    }
}
