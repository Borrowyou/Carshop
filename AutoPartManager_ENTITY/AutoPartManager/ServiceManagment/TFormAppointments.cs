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
        FormAllServices FormAllServ;
        DMAppointments DMAppoitm;
        public TFormAppointments()
        {
            InitializeComponent();
            try
            {
                DMAppoitm = new DMAppointments();
                if (FormAllServ != null)
                    FormAllServ.Dispose();
                FormAllServ = new FormAllServices();
                FormAllServ.TopLevel = false;
                FormAllServ.Dock = DockStyle.Fill;
                pnlFormHolder.Controls.Clear();
                pnlFormHolder.Controls.Add(FormAllServ);
                FormAllServ.ShowInTaskbar = true;
                FormAllServ.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void InitFormAppManage()
        {
            if (FormManageAppoitment != null)
                FormManageAppoitment.Dispose();
            FormManageAppoitment = new TFormManageAppoitment(true);
            FormManageAppoitment.TopLevel = false;
            FormManageAppoitment.Dock = DockStyle.Fill;
            pnlFormHolder.Controls.Clear();
            pnlFormHolder.Controls.Add(FormManageAppoitment);
            FormManageAppoitment.LoadOrInsAppt(-1);
            FormManageAppoitment.Show();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            InitFormAppManage();

        }

        private void btnViewAppoitments_Click(object sender, EventArgs e)
        {
            if (FormAllAppt != null)
                FormAllAppt.Dispose();
            FormAllAppt = new FormAllAppoitments();
            FormAllAppt.TopLevel = false;
            FormAllAppt.Dock = DockStyle.Fill;
            pnlFormHolder.Controls.Clear();
            pnlFormHolder.Controls.Add(FormAllAppt);
            FormAllAppt.Show();

            
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            if (FormAllServ != null)
                FormAllServ.Dispose();
            FormAllServ = new FormAllServices();
            FormAllServ.TopLevel = false;
            FormAllServ.Dock = DockStyle.Fill;
            pnlFormHolder.Controls.Clear();
            pnlFormHolder.Controls.Add(FormAllServ);
            FormAllServ.ShowInTaskbar = true;
            FormAllServ.Show();


        }

        private void pnlFormHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBtns_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
