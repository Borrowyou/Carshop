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
    public partial class TFormAppointments : Form
    {
        TFormManageAppoitment FormManageAppoitment;
        FormAllAppoitments FormAllAppt;
        DMAppointments DMAppoitm;
        public TFormAppointments()
        {
            InitializeComponent();
            try
            {
                DMAppoitm = new DMAppointments();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
    
            }
        }

        public void InitFormAppManage()
        {
            if (FormManageAppoitment == null)
                FormManageAppoitment = new TFormManageAppoitment(true);
            FormManageAppoitment.TopLevel = false;
            FormManageAppoitment.Dock = DockStyle.Fill;
            pnlFormHolder.Controls.Clear();
            pnlFormHolder.Controls.Add(FormManageAppoitment);
            FormManageAppoitment.Show();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            InitFormAppManage();

        }

        private void btnViewAppoitments_Click(object sender, EventArgs e)
        {
            if (FormAllAppt == null)
                FormAllAppt = new FormAllAppoitments();
            FormAllAppt.TopLevel = false;
            FormAllAppt.Dock = DockStyle.Fill;
            pnlFormHolder.Controls.Clear();
            pnlFormHolder.Controls.Add(FormAllAppt);
            FormAllAppt.Show();
            
        }

    }
}
