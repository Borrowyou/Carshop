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
        }

        private void sERVICE_WORKSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (CurrServWork().SERVICE_WORK_ID != null)
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
            EditCurrentAppoitment();
        }

        private void EditCurrentAppoitment()
        {
            int AppID = CurrServWork().APPOITMENT_ID;
            TFormManageAppoitment FormManageAppoitment;
            FormManageAppoitment = new TFormManageAppoitment(false);
            FormManageAppoitment.FormBorderStyle = FormBorderStyle.Sizable;
            FormManageAppoitment.LoadOrInsAppt(AppID);
            FormManageAppoitment.ShowDialog();

        }
    }
}
