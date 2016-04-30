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

namespace DataManagment
{
    public partial class FormAllClients : Form
    {
        DMClients CDMClients;
        public FormManageClients FormManage { get; set; }
        public FormAllClients()
        {
            InitializeComponent();
            FormManage.Show();
        }

        private void FormManageClients_Load(object sender, EventArgs e)
        {
            CDMClients = new DMClients();
            CDMClients.LoadAllClients();
            SetDataSource();
        }

        private void SetDataSource()
        {
            AllClientsBindingSource.DataSource = CDMClients.GetClients().Local.ToBindingList();
        }

        private void AllClientsBindingSource_PositionChanged(object sender, EventArgs e)
        {
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        }



    }
}
