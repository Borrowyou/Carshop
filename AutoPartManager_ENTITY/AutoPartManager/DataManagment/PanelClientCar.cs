using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoPartDataModels;
using System.Data.Entity;

namespace DataManagment
{
    public partial class PanelClientCar : UserControl
    {
        public delegate void ReSetAll();
        public ReSetAll Setplaces;
        public int PanelID;
        public CLIENT_CARS ClientCar;
        public bool StateNew;
        public DMClients CDMClients;

        public PanelClientCar()
        {           
            ClientsDset.InitAdapters();
        }


        public PanelClientCar(CLIENT_CARS AClientCar, int ClientID)
        {
            InitializeComponent();
            CDMClients = new DMClients();
            if (AClientCar == null)
                GenerateNewClient(ClientID);
            else
            {
                ClientCar = AClientCar;
                StateNew = false;
            }
            
            SetDataSources();
        }
        private void GenerateNewClient(int ClientID)
        {
            ClientCar = new CLIENT_CARS();
            ClientCar.CLIENT_CAR_ID = CDMClients.GenID("CLIENTS_CAR_ID");
            ClientCar.CLIENT_ID = ClientID;
            StateNew = true;
        }

        private void SetDataSources()
        {
            cLIENT_CARSBindingSource.DataSource = ClientCar;
            AllCarsBindSrc.DataSource = CDMClients.CurrContex.Cars.ToList();
            EngTypeBindSrc.DataSource = CDMClients.GetEngineTypes().ToList();
        }

       
        private void LoadClientCarID(int ClientID, int ClientCarID)
        {

        }

        private void PanelClientCar_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Setplaces();
            
        }

        private void cBxMark_EditValueChanged(object sender, EventArgs e)
        {
            
        }

    

        public void SaveClientCars(Clients CurrClient)
        {
            try
            {
                cLIENT_CARSBindingSource.EndEdit();
                CurrClient.CLIENT_CARS.Add(ClientCar);
                //if (StateNew)
                //    CDMClients.CurrContex.Entry(ClientCar).State = EntityState.Added;
                //else
                //{
                //    CDMClients.CurrContex.Entry(ClientCar).State = EntityState.Modified;
                //}
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex.Message);
            }
            
        }

        private void cLIENT_CARSBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (ClientCar != null)
                ModelsBindSrc.DataSource = CDMClients.CurrContex.Models.
                            Where(m => m.CAR_ID == ((CLIENT_CARS)cLIENT_CARSBindingSource.Current).CAR_ID).ToList();
        }

        private void cLIENT_CARSBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void ModelsBindSrc_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (ClientCar != null)
            {
                if (lookUpEdit2.EditValue != null && lookUpEdit2.Text != "")
                {
                    int CarID = Convert.ToInt32(LupCBoxCars.EditValue);
                    int ModelID = Convert.ToInt32(lookUpEdit2.EditValue);
                    YearsList.DataSource = CDMClients.LoadCarYears(CarID, ModelID).ToList();

                }
            }
             
        }
        private CLIENT_CARS CurrClientCar()
        {
            return (CLIENT_CARS)cLIENT_CARSBindingSource.Current;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (CDMClients != null && CurrClientCar().MODEL_ID != 0)
            {
                int Year = (int)lookUpEdit1.EditValue;
                int SubModelID = CDMClients.GetSubModelIDByYear(CurrClientCar().MODEL_ID, Year);
                CurrClientCar().SUB_MODEL_ID = SubModelID;
                
            }
        }

        public bool IsCarRecordValid()
        { 
            StringBuilder ErrorList = new StringBuilder();
            if (CurrClientCar().CAR_ID == 0)
                ErrorList.AppendLine("Моля изберете марка или премахнете колата");

            if (CurrClientCar().MODEL_ID == 0)
                ErrorList.AppendLine("Моля изберете модел или премахнете колата");
            if (CurrClientCar().CAR_YEAR == 0)
                ErrorList.AppendLine("Моля изберете година или премахнете колата");
            if (ErrorList.Length > 0)
                MessageBox.Show(ErrorList.ToString());
            return ErrorList.Length == 0;

        }

    }

    
}
