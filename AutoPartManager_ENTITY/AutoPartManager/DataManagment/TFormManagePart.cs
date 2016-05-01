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
        DMParts CDMParts;

        public TFormManagePart()
        {
            InitializeComponent();
            CDMParts = new DMParts();
            Dock = DockStyle.Fill;
        }
        public TFormManagePart(TPartsDataSet APartsDSet)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void LoadPartByID(int PartID)
        {
            partsBindingSource.DataSource = CDMParts.CurrContex.Parts.Where(p => p.Part_ID == PartID).ToList();
        }
        


        private void TFormManagePart_Load(object sender, EventArgs e)
        {

        }
    }
}
