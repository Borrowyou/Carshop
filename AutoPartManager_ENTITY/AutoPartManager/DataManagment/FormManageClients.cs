using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AutoPartDataModels;

namespace DataManagment
{
    public partial class FormManageClients : Form
    {
        public delegate void RefreshGrid();
        public RefreshGrid ReloadFunc;
        bool InsertState;
        List<PanelClientCar> ListClientCars;
        int PnlTop;
        int DefHeight;
        int btnPosTop;
        List<CLIENT_CARS> ClientCars;
        public int FClientID { get; set; }
        public DMClients CDMClients;
        

        public FormManageClients()
        {
            InitializeComponent();
            CDMClients = new DMClients();
            ListClientCars = new List<PanelClientCar>();
            SetDataSources();
            PnlTop = RichtxtDetails.Top + RichtxtDetails.Height + 5;
            DefHeight = Height;
            btnPosTop = PnlTop;


        }

        public void SetDataSources()
        {
            lOOKUP_ITEMSBindingSource.DataSource = CDMClients.GetClienTypesLookUp().ToList();      
        }

        private void FormManageClients_Load(object sender, EventArgs e)
        {
        }

        public Clients CurrClient()
        {
            return (Clients)clientsBindingSource.Current;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveClientData();
            if (ReloadFunc != null)
                ReloadFunc();
        }

        private void SaveClientData()
        {
            txtEditDetails.EditValue = RichtxtDetails.Text;
            foreach (var ClientCar in ListClientCars)
                ClientCar.SaveClientCars(CurrClient());
            clientsBindingSource.EndEdit();
            try
            {
                if (InsertState)
                {
                    CDMClients.CurrContex.Entry(CurrClient()).State = EntityState.Added;
                }
                else
                {
                    CDMClients.CurrContex.Entry(CurrClient()).State = EntityState.Modified;
                }
                CDMClients.CurrContex.SaveChanges();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            btnAddCar.Top = RichtxtDetails.Top + RichtxtDetails.Height + 5;
            btnSave.Top = PnlTop;
            for (int i = 0; i < ListClientCars.Count; i++)
                ListClientCars[i].Top = PnlTop + i * ListClientCars[i].Height;
            
            if (ListClientCars.Count > 0)
            {
                btnAddCar.Top = ListClientCars.Last().Top + ListClientCars.Last().Height;
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
            ListClientCars.Add(new PanelClientCar(null, 
                ((Clients)clientsBindingSource.Current).CLIENT_ID ));
            ListClientCars.Last().Setplaces = ClearAndReplace;
            Controls.Add(ListClientCars.Last());
            ClearAndReplace();
        }

        public void LoadOrInsertClient(int ClientID)
        {
            FClientID = ClientID;
            for (int i = 0; i < ListClientCars.Count; i++)
            {
                ListClientCars[i].Dispose();
            }
            ClearAndReplace();
            if (ClientID == -1)
            {
                InitNewCLient();
            }
            else
            {
                InsertState = false;
                BindClientByID(ClientID);
                ClientCars = CDMClients.LoadClientCars(ClientID).ToList();
                foreach (CLIENT_CARS CurrCar in ClientCars)
                {
                    ListClientCars.Add(new PanelClientCar(CurrCar, -1));
                    ListClientCars.Last().Setplaces = ClearAndReplace;
                    Controls.Add(ListClientCars.Last());
                    ClearAndReplace();  
                }
            }
            ClearAndReplace();
        }


        public void BindClientByID(int ClientID)
        {

            clientsBindingSource.DataSource = CDMClients.CurrContex.Clients.Where(c => c.CLIENT_ID == ClientID).ToList();
            CDMClients.CurrContex.Clients.Attach((Clients)clientsBindingSource.Current);
            
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void InitNewCLient()
        {
            InsertState = true;
            clientsBindingSource.AddNew();
            CurrClient().CLIENT_ID = CDMClients.GenID("CLIENTS");
            CurrClient().CLIENT_FORM = DateTime.Now;
            CurrClient().CLIENT_TYPE = DMStrings.ClientTypePrivate;
                
            clientsBindingSource.ResetBindings(false);
        }


    }
}
