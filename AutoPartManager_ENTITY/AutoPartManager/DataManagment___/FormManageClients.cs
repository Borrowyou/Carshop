using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManagment
{
    public partial class FormManageClients : Form
    {
        List<PanelClientCar> ListClientCars;
        int PnlTop;
        int DefHeight;
        int btnPosTop;
        public int FClientID { get; set; }

        public FormManageClients()
        {
            InitializeComponent();
            //ClientsDset.InitAdapters();
            ListClientCars = new List<PanelClientCar>();
            PnlTop = RichtxtDetails.Top + RichtxtDetails.Height + 5;
            DefHeight = Height;
        }
        //public FormManageClients()
       // {
        //    InitializeComponent();
            /*ClientsDset = AClientDet;
            ClientBindingSource.DataSource = ClientsDset;
            PnlTop = RichtxtDetails.Top + RichtxtDetails.Height + 5;
            DefHeight = Height;
            btnPosTop = btnAddCar.Top;
            ListClientCars = new List<PanelClientCar>();*/
 
        //}


        private void FormManageClients_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEditDetails.EditValue = RichtxtDetails.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientBindingSource.AddNew();
        }

        private void chkIsFIrm_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            ClearAndReplace();
            ListClientCars.Add(new PanelClientCar());
            Controls.Add(ListClientCars.Last());
            ListClientCars.Last().Setplaces = ClearAndReplace;
            ListClientCars.Last().Left = RichtxtDetails.Left;
            ClearAndReplace();
            ClearAndReplace();
        }

        private void RemoveDisposedListObjects()
        {
            for (int i = 0; i < ListClientCars.Count; i++)
            {
                if (ListClientCars[i].IsDisposed)
                {
                    ListClientCars.RemoveAt(i);
                    RemoveDisposedListObjects();
                }
            }
            
        }
        private void ReArrangeObjects()
        {
            Height = DefHeight;
            btnAddCar.Top = btnPosTop;
            for (int i = 0; i < ListClientCars.Count; i++)
                ListClientCars[i].Top = PnlTop + i * ListClientCars[i].Height;
            
            if (ListClientCars.Count > 0)
            {
                btnAddCar.Top = ListClientCars.Last().Top + ListClientCars.Last().Height + 5;
                Height = ListClientCars.Last().Top + ListClientCars.Last().Height + 60;
            }
        }
        private void ClearAndReplace()
        { 
            RemoveDisposedListObjects();
            ReArrangeObjects();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            RemoveDisposedListObjects();
            ReArrangeObjects();
        }

        private void btnAddCar_Click_1(object sender, EventArgs e)
        {
            ListClientCars.Add(new PanelClientCar(FClientID, -1));
            ListClientCars.Last().Setplaces = ClearAndReplace;
            Controls.Add(ListClientCars.Last());
            ClearAndReplace();
        }

        public void LoadOrInsertClient(int ClientID)
        {
            /*FClientID = ClientID;
            for (int i = 0; i < ListClientCars.Count; i++)
            {
                ListClientCars[i].Dispose();
            }
            ClearAndReplace();
            if (ClientID == -1)
            {
                ClientBindingSource.AddNew();
            }
            else
            {
                ClientsDset.LoadClientByID(ClientID);
                ClientsDset.LoadClientsCars(ClientID);
 
                foreach (DataRow CurrRow in ClientsDset.CLIENT_CARS)
                {
                    ListClientCars.Add(new PanelClientCar(ClientID, Convert.ToInt32(CurrRow["CLIENT_CAR_ID"])));
                    ListClientCars.Last().Setplaces = ClearAndReplace;
                    Controls.Add(ListClientCars.Last());
                    ClearAndReplace();  
                }
            } */
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cLIENT_TYPELabel_Click(object sender, EventArgs e)
        {

        }

        private void cLIENT_TYPELookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
