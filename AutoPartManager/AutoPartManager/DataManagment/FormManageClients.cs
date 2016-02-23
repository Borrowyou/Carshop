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

        public FormManageClients()
        {
            InitializeComponent();
            ClientsDset.InitAdapters();
            ListClientCars = new List<PanelClientCar>();
            PnlTop = RichtxtDetails.Top + RichtxtDetails.Height + 5;
            DefHeight = Height;
        }
        public FormManageClients(ClientsDataSet AClientDet)
        {
            InitializeComponent();
            ClientsDset = AClientDet;
            ClientBindingSource.DataSource = ClientsDset;
            ClientBindingSource.DataSource = ClientsDset.ClientByID;
            PnlTop = RichtxtDetails.Top + RichtxtDetails.Height + 5;
            DefHeight = Height;
            btnPosTop = btnAddCar.Top;
            ListClientCars = new List<PanelClientCar>();
 
        }


        private void FormManageClients_Load(object sender, EventArgs e)
        {
            ClientsDset.LoadClientByID(1);
        }
        private void LinkControls()
        { 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEditDetails.EditValue = RichtxtDetails.Text;
            ClientBindingSource.EndEdit();
            ClientsDset.SaveClientByID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientBindingSource.AddNew();
        }

        private void ClientBindingSource_PositionChanged(object sender, EventArgs e)
        {
            ;
        }

        private void ClientBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void chkIsFIrm_CheckedChanged(object sender, EventArgs e)
        {
            chkIsFIrm.EditValue = (chkIsFIrm.Checked) ? "Y" : "N";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListClientCars.Add(new PanelClientCar());
            ListClientCars.Last().Setplaces = ClearAndReplace;
            Controls.Add(ListClientCars.Last());
            ClearAndReplace();
        }

    }
}
