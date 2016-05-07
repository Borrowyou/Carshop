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
    public partial class FormEmployees : Form
    {
        DMEmployees CDMEmployees;
        FormManageEmployee FormManageEmpl;

        public FormEmployees()
        {
            InitializeComponent();
            CDMEmployees = new DMEmployees();
            FormManageEmpl = new FormManageEmployee();
            FormManageEmpl.TopLevel = false;
            FormManageEmpl.ReloadFunc = CDMEmployees.LoadAllEMployees;

            pnlFormClient.Controls.Add(FormManageEmpl);
            FormManageEmpl.Show();
        }

        private void SetDataSources()
        {
            EmployeesBindingSrc.DataSource = CDMEmployees.GetEmployeesDBSet().Local.ToBindingList();
        }


        private void FormManageClients_Load(object sender, EventArgs e)
        {
            SetDataSources();
            CDMEmployees.LoadAllEMployees();
        }

        private void AllClientsBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormManageEmpl.LoadOrInsertEmpl(-1);
        }

        private void clientsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                FormManageEmpl.LoadOrInsertEmpl(((EMPLOYEES)EmployeesBindingSrc.Current).EMPLOYEE_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
