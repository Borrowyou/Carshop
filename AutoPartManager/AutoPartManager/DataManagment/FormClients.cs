using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManagment
{
    public partial class FormClients : Form
    {
        public ClientsDataSet ClientsDset { get; set; }

        public FormClients()
        {
            InitializeComponent();
            clientsDataSet.InitAdapters();
            FormManageClients FormManage = new FormManageClients(clientsDataSet);
            FormManage.TopLevel = false;
            pnlFrameClients.Controls.Add(FormManage);
            FormManage.Show();
        }

        private void FormManageClients_Load(object sender, EventArgs e)
        {
            clientsDataSet.LoadClients();
        }

        private void AllClientsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            clientsDataSet.LoadClientByID((int)clientsDataSet.Clients.Rows[AllClientsBindingSource.Position]["CLIENT_ID"]);
        }



    }
}
