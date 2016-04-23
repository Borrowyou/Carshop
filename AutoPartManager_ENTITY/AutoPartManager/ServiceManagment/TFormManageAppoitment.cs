using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Objects;
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
        APPOITMENT CurrentApp;

        public TFormManageAppoitment()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            DMAppoitm = new DMAppointments();
            InitNewAppoitment();
            SetDataSources();
            
        }

        public void InitNewAppoitment()
        {
            aPPOITMENTBindingSource.AddNew();
            ((APPOITMENT)aPPOITMENTBindingSource.Current).APPOITMENT_DATE = DateTime.Now;
        }

        public void ReloadAllClients()
        {
            clientBindingSource.DataSource = DMAppoitm.GetAllClients().ToList();
        }

        public void SetDataSources()
        {
            clientBindingSource.DataSource = DMAppoitm.GetAllClients().ToList();
        }

        private void aPPOITMENTBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void aPPOITMENTBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            int ClientID = ((APPOITMENT)aPPOITMENTBindingSource.Current).CLIENT_ID;
            cLIENT_CARSBindingSource.DataSource = DMAppoitm.GetAllClients_Cars(ClientID).ToList();
        }
        private void Save()
        {
            try
            {
                aPPOITMENTBindingSource.EndEdit();
                ((APPOITMENT)aPPOITMENTBindingSource.Current).APPOITMENT_ID = DMAppoitm.GenID("APPOITMENTS_ID");
                DMAppoitm.CurrContex.APPOITMENTS.Add(((APPOITMENT)aPPOITMENTBindingSource.Current));
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
            Save();
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

        private APPOITMENT CurrentAppoitment()
        {
            return (APPOITMENT)aPPOITMENTBindingSource.Current;
        }

    }
}
