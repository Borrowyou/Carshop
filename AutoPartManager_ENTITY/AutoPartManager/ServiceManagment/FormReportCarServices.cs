using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoPartDataModels;

namespace ServiceManagment
{
    public partial class FormReportCarServices : Form
    {
        DMReports CDMReports;
        public FormReportCarServices()
        {
            InitializeComponent();
            CDMReports = new DMReports();
            SetDataSources();
        }

        private void SetDataSources()
        {
            ServiceWorksBindingSrc.DataSource = CDMReports.GetServiceDBSet().Local.ToBindingList();
            ClientsBindSrc.DataSource = CDMReports.GetAllClients().ToList();
            CarSrchBindingSrc.DataSource = CDMReports.GetAllCars().ToList();
        }


        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFindClCar_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit2.EditValue != null)
            {
                int CurrClCar = (int)searchLookUpEdit2.EditValue;
                CDMReports.LoadCarServicesByID(CurrClCar);
            }
        }

        private void gridViewCarRepairs_DoubleClick(object sender, EventArgs e)
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

        private SERVICE_WORKS CurrServWork()
        {
            return (SERVICE_WORKS)ServiceWorksBindingSrc.Current;
        }

    }
}
