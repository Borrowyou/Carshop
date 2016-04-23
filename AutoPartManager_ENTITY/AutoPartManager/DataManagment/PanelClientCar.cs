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

        public PanelClientCar()
        {
            InitializeComponent();
            ClientsDset.InitAdapters();
            ClientCarsBindingSrc.AddNew();
            ClientsDset.LoadMarks();
            ClientsDset.LoadLookUpByName(DMStrings.EngTypeLup);
        }

        public PanelClientCar(int ClientID, int ClientCarID)
        {
            InitializeComponent();
            LoadClientCarID(ClientID, ClientCarID);
        }
        private void LoadClientCarID(int ClientID, int ClientCarID)
        {
            ClientsDset.InitAdapters();
            ClientsDset.FClientID = ClientID;
            if (ClientCarID == -1)
                ClientCarsBindingSrc.AddNew();
            else
                ClientsDset.LoadClientCarByID(ClientCarID);
            ClientsDset.LoadMarks();
            ClientsDset.LoadCarLookUps();
            ClientsDset.LoadLookUpByName(DMStrings.EngTypeLup);
        }

        private void PanelClientCar_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ClientCarsBindingSrc.RemoveCurrent();
            ClientCarsBindingSrc.EndEdit();
            ClientsDset.SaveClientByID();

            ClientsDset.AcceptChanges();
            this.Dispose();
            Setplaces();
        }

        private void cBxMark_EditValueChanged(object sender, EventArgs e)
        {
            ;
        }

    

        public void SaveClientCars()
        {
            try
            {
                ClientCarsBindingSrc.EndEdit();
                ClientsDset.ClientsCarsTblAdapter.Update(ClientsDset.CLIENT_CARS);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex.Message);
            }
        }
    }
}
