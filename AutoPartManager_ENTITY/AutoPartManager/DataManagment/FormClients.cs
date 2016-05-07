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

namespace DataManagment
{
    public partial class FormClients : Form
    {
        public ClientsDataSet ClientsDset { get; set; }
        public FormManageClients FormManage { get; set; }
        DMClients CDMClients;
        public FormClients()
        {
            InitializeComponent();
           // clientsDataSet.InitAdapters();
            FormManage = new FormManageClients();
            FormManage.TopLevel = false;
            FormManage.ReloadFunc = RefreshGrid;
            pnlFormClient.Controls.Add(FormManage);
            FormManage.Show();
        }

        private void SetDataSources()
        {
            clientsBindingSource.DataSource = CDMClients.GetClientsDbSet().Local.ToBindingList();
        }

        private void RefreshGrid()
        {
            CDMClients.LoadAllClients();
        }

        private void FormManageClients_Load(object sender, EventArgs e)
        {
            CDMClients = new DMClients();
            SetDataSources();
            CDMClients.LoadAllClients();
        }

        private void AllClientsBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormManage.LoadOrInsertClient(-1);
        }

        private void clientsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                FormManage.LoadOrInsertClient(((Clients)clientsBindingSource.Current).CLIENT_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void обновиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CurrSelectedPart = clientsBindingSource.Current;

            CDMClients.LoadAllClients();
            

        }

        private Clients CurrClient()
        {
            return (Clients)clientsBindingSource.Current;
        }


    }
}
