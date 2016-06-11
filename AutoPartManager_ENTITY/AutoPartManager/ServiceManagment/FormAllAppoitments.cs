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
using AutoPartDataModels;

namespace ServiceManagment
{
    public partial class FormAllAppoitments : Form
    {
        DMAppointments CDMAppoitments;
        public FormAllAppoitments()
        {
            InitializeComponent();
            CDMAppoitments = new DMAppointments();
        }

        private void SetDataSources()
        {
            aPPOITMENTSBindingSource.DataSource = CDMAppoitments.GetAppoitmentsDBSet().Local.ToBindingList();
        }
        private void FormAllAppoitments_Load(object sender, EventArgs e)
        {
            
            CDMAppoitments.LoadAllAppoitments();
            SetDataSources();
             
        }

        private void gridViewAppoitments_DoubleClick(object sender, EventArgs e)
        {
            EditCurrentAppoitment();
        }

        private void EditCurrentAppoitment()
        {
            if (SelectedApp() != null)
            {
                int AppID = SelectedApp().APPOITMENT_ID;
                TFormManageAppoitment FormManageAppoitment;
                FormManageAppoitment = new TFormManageAppoitment(false);
                FormManageAppoitment.FormBorderStyle = FormBorderStyle.Sizable;
                FormManageAppoitment.LoadOrInsAppt(AppID);
                FormManageAppoitment.ShowDialog();
                
                CDMAppoitments.LoadAllAppoitments();
                SetDataSources();
            }
        }

        private APPOITMENTS SelectedApp()
        {
            return (APPOITMENTS)aPPOITMENTSBindingSource.Current;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuCancel_Click(object sender, EventArgs e)
        {
            CDMAppoitments.CancelAppoitmentByID(SelectedApp().APPOITMENT_ID);
            CDMAppoitments.LoadAllAppoitments();
        }
    }
}
