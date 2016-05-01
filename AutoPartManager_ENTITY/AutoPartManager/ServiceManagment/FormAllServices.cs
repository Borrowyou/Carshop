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
            WorkStatusBindingSrc.DataSource = CDMAppoitm.CurrContex.LOOKUP_ITEMS
                                        .Where(l => l.LOOKUP_NAME == DMStrings.ServiceWorkStatuses).ToList();
        }
    }
}
