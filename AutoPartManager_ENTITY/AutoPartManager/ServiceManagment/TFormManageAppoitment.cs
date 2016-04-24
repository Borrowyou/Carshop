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
using DataManagment;

namespace ServiceManagment
{
    public partial class TFormManageAppoitment : Form
    {
        DMAppointments DMAppoitm;
        Logger logger;
        FormManageClients FormMngClients;

        public TFormManageAppoitment()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            DMAppoitm = new DMAppointments();
            InitNewAppoitment();
            SetDataSources();
            DMAppoitm.CurrContex.SERVICE_WORKS.Load();
            
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
                DMAppoitm.CurrContex.APPOITMENTS.Add(((APPOITMENTS)aPPOITMENTBindingSource.Current));
                DMAppoitm.CurrContex.SaveChanges();
            }
            catch(Exception Ex)
            {
                logger.Error(Ex);
                throw Ex;
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
            //pnlExtWindows.Controls.Add(FormMngClients);
            FormMngClients.ShowDialog();
            ReloadAllClients();
            gridLookUpEdit1.EditValue = FormMngClients.FClientID;
            //CurrentAppoitment().CLIENT_ID = FormMngClients.FClientID;
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

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Save();
        }

    }
}
