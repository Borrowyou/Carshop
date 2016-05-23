using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AutoPartDataModels;
using DataManagment;

namespace ServiceManagment
{
    public partial class FormAllServices : Form
    {
        DMAppointments CDMAppoitm;
        public FormAllServices()
        {
            InitializeComponent();
            CDMAppoitm = new DMAppointments();
            SetDataSources();
            CDMAppoitm.LoadServices();
        }
        private void SetDataSources()
        {
            sERVICE_WORKSBindingSource.DataSource = CDMAppoitm.GetServiceWorksDBSet().Local.ToBindingList();
            WorkStatusBindingSrc.DataSource = CDMAppoitm.GetServiceWorkStatuses().ToList();
            MechanicsBindSrc.DataSource = CDMAppoitm.GetMechanicsList().ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFilteredServiceWorks();

        }

        private void LoadFilteredServiceWorks()
        {
            int MechID = 0;
            string WorkStatus = (string)LookUpStatus.EditValue;
            CDMAppoitm.LoadServicesByMechAndStatus(MechID, WorkStatus);
            sERVICE_WORKSBindingSource.DataSource = CDMAppoitm.GetServiceWorksDBSet().Local.ToBindingList();
        }

        private void sERVICE_WORKSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (CurrServWork() != null)
            {
                var QryRes = CDMAppoitm.GetServWorkEmployees(CurrServWork().SERVICE_WORK_ID);
                if (QryRes != null)
                {
                    var list = QryRes.ToList();
                    MechanicsBindSrc.DataSource = list;
                    sERVICE_WORKSBindingSource.ResetBindings(false);
                    MechanicsBindSrc.ResetBindings(false);
                }
            }
        }

        private SERVICE_WORKS CurrServWork()
        {
            return (SERVICE_WORKS)sERVICE_WORKSBindingSource.Current;
        }
        private List<EMPLOYEES_SERVICE_WORKS> GetCurrEmployeesList()
        {
            return CurrServWork().EMPLOYEES_SERVICE_WORKS.ToList();
        }

        private void sERVICE_WORKSGridControl_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void EditCurrentAppoitment()
        {
            if (CurrServWork() != null)
            {
                int AppID = CurrServWork().APPOITMENT_ID;
                TFormManageAppoitment FormManageAppoitment;
                FormManageAppoitment = new TFormManageAppoitment(false);
                FormManageAppoitment.FormBorderStyle = FormBorderStyle.Sizable;
                FormManageAppoitment.LoadOrInsAppt(AppID);
                FormManageAppoitment.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CDMAppoitm.CurrContex.SaveChanges();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            EditCurrentAppoitment();
        }

        private void gridView1_ColumnChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "WORK_STATUS")
            {
                if(CurrServWork().WORK_STATUS == DMStrings.ServiceWorkStarted)
                    CurrServWork().TIME_START = DateTime.Now;
                else if (CurrServWork().WORK_STATUS == DMStrings.ServiceWorkFinished)
                    CurrServWork().TIME_FINISH = DateTime.Now;
                sERVICE_WORKSBindingSource.ResetCurrentItem();
            }
        }
    }
}
