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
            SetDataSources();
            CDMAppoitments.LoadAllAppoitments();
             
        }

    }
}
