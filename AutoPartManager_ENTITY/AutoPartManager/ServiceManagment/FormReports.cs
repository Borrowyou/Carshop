using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceManagment
{
    public partial class FormReports : Form
    {
        FormReportCarServices FormCarServices;
        public FormReports()
        {
            InitializeComponent();
            InitFormCarServices();
        }


        public void InitFormCarServices()
        {
            if (FormCarServices != null)
                FormCarServices.Dispose();
            FormCarServices = new FormReportCarServices();
            FormCarServices.TopLevel = false;
            FormCarServices.Dock = DockStyle.Fill;
            pnlFormHolder.Controls.Clear();
            pnlFormHolder.Controls.Add(FormCarServices);
            FormCarServices.Show();
        }

        private void btnCarServicesReport_Click(object sender, EventArgs e)
        {
            InitFormCarServices();
        }
    }
}
