using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using NLog;
using AutoPartDataModels;
using DataManagment;

namespace ServiceManagment
{
    public partial class TFormManageAppoitment : Form
    {
        DMAppointments DMAppoitm;
        Logger logger;
        FormManageClients FormMngClients;
        public bool InsertState;

        public TFormManageAppoitment()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            DMAppoitm = new DMAppointments();
            LoadCommonData();
            InitNewAppoitment();
            SetDataSources();
            DMAppoitm.CurrContex.SERVICE_WORKS.Include(l =>l.LOOKUP_ITEMS) .Load();
            
        }

        public TFormManageAppoitment(bool AInsertState)
        {
            InitializeComponent();
            InsertState = AInsertState;
            logger = LogManager.GetCurrentClassLogger();
            DMAppoitm = new DMAppointments();
            LoadCommonData();
            InitNewAppoitment();
            SetDataSources();
            DMAppoitm.CurrContex.SERVICE_WORKS.Include(l => l.LOOKUP_ITEMS).Load();

        }
        public void LoadCommonData()
        {
            sERVICESBindingSource.DataSource = DMAppoitm.CurrContex.SERVICES.ToList();
            lOOKUP_ITEMSBindingSource.DataSource = DMAppoitm.CurrContex.LOOKUP_ITEMS.ToList();
        }

        public void InitNewAppoitment()
        {
            aPPOITMENTBindingSource.AddNew();
            ((APPOITMENTS)aPPOITMENTBindingSource.Current).APPOITMENT_ID = DMAppoitm.GenID("APPOITMENTS_ID");
            ((APPOITMENTS)aPPOITMENTBindingSource.Current).APPOITMENT_DATE = DateTime.Now;
        }

        public void ReloadAllClients()
        {
            clientBindingSource.DataSource = DMAppoitm.GetAllClients().ToList();

        }

        public void SetDataSources()
        {
            clientBindingSource.DataSource = DMAppoitm.GetAllClients().ToList();
            sERVICE_WORKSBindingSource.DataSource = DMAppoitm.CurrContex.SERVICE_WORKS.Local.ToBindingList();
            EmpListBindSrc.DataSource = DMAppoitm.CurrContex.EMPLOYEES.ToList();
        }

        private void aPPOITMENTBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void aPPOITMENTBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            int ClientID = ((APPOITMENTS)aPPOITMENTBindingSource.Current).CLIENT_ID;
            cLIENT_CARSBindingSource.DataSource = DMAppoitm.GetAllClients_Cars(ClientID).ToList();
        }
        private void Save()
        {
            try
            {
                aPPOITMENTBindingSource.EndEdit();
                sERVICE_WORKSBindingSource.EndEdit();
                if (InsertState)
                {
                    DMAppoitm.CurrContex.APPOITMENTS.Add(((APPOITMENTS)aPPOITMENTBindingSource.Current));    
                }
                else
                {
                    DMAppoitm.CurrContex.APPOITMENTS.Attach(((APPOITMENTS)aPPOITMENTBindingSource.Current));
                }

                DMAppoitm.CurrContex.SaveChanges();
                InsertState = false;
            }
            catch(Exception Ex)
            {
                logger.Error(Ex);
                MessageBox.Show(Ex.Message);
            }
            
        
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void aPPOITMENTBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormMngClients = new FormManageClients();
            FormMngClients.FormBorderStyle = FormBorderStyle.Sizable;
            FormMngClients.LoadOrInsertClient(-1);
            FormMngClients.ShowDialog();
            ReloadAllClients();
            gridLookUpEdit1.EditValue = FormMngClients.FClientID;
        }

        private APPOITMENTS CurrentAppoitment()
        {
            return (APPOITMENTS)aPPOITMENTBindingSource.Current;
        }

        private void btnAddServiceWork_Click(object sender, EventArgs e)
        {
            sERVICE_WORKSBindingSource.AddNew();
            ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).SERVICE_WORK_ID = DMAppoitm.GenID("SERVICE_WORK_ID");
            ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).APPOITMENT_ID = ((APPOITMENTS)aPPOITMENTBindingSource.Current).APPOITMENT_ID;
            ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).WORK_STATUS = DMStrings.ServiceWorkPend;
            CurrAppoitment().SERVICE_WORKS.Add(CurrentServiceWork());

        }
        private SERVICE_WORKS CurrentServiceWork()
        {
            return (SERVICE_WORKS)sERVICE_WORKSBindingSource.Current;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnAddNewWorker_Click(object sender, EventArgs e)
        {
            EmplSrvBindingSrc.AddNew();
            CurrEmplWork().EMPLOYEE_WORK_ID = DMAppoitm.GenID("EMPLOYEE_WORKS");
            CurrEmplWork().SERVICE_WORK_ID = CurrentServiceWork().SERVICE_WORK_ID;
            CurrentServiceWork().EMPLOYEES_SERVICE_WORKS.Add(CurrEmplWork());  
        }

        private EMPLOYEES_SERVICE_WORKS CurrEmplWork()
        {
            return (EMPLOYEES_SERVICE_WORKS)EmplSrvBindingSrc.Current;
        }

        private void sERVICE_WORKSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadEmplServices()
        { 
            
        }

        private APPOITMENTS CurrAppoitment()
        {
            return (APPOITMENTS)aPPOITMENTBindingSource.Current;
        }

    }
}
