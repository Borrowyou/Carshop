using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManagment;
using System.Reflection;
using ServiceManagment;
namespace AutoPartManager
{
    public partial class FormAutoPartManager : Form
    {
        TFormAppointments FormAppointments;
        

        public FormAutoPartManager()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClients FormClients = new FormClients();
            FormClients.Show();
        }

        private void FormAutoPartManager_Load(object sender, EventArgs e)
        {
            InitFormAppointments();
        }

        private void частиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TFormParts FormParts = new TFormParts();
            FormParts.Show();
        }

        private void btnAppoitments_Click(object sender, EventArgs e)
        {
            InitFormAppointments();
       } 

        private void InitFormAppointments()
        {
            FormAppointments = new TFormAppointments();
            FormAppointments.TopLevel = false;

            pnlForm.Controls.Add(FormAppointments);
            FormAppointments.Dock = DockStyle.Fill;
            FormAppointments.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TFormServicesManage FormServiceManage = new TFormServicesManage();
            FormServiceManage.Show();

        }

    }
}
