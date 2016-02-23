using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManagment
{
    public partial class PanelClientCar : UserControl
    {
        public delegate void ReSetAll();
        public ReSetAll Setplaces;
        public int PanelID;
        ClientsDataSet ClientsDSet;
        public PanelClientCar()
        {
            InitializeComponent();
        }
        public PanelClientCar(ClientsDataSet AClientsDSet, int APanelID)
        {
            InitializeComponent();
            ClientsDSet = AClientsDSet;
            PanelID = APanelID;
        }

        private void PanelClientCar_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Setplaces();
            
        }
    }
}
