using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AutoPartDataModels;

namespace DataManagment
{
    public partial class FormManageEmployee : Form
    {
        public bool InsertState;
        DMEmployees CDMEmployees;
        public delegate void RefreshGrid();
        public RefreshGrid ReloadFunc;

        public FormManageEmployee()
        {
            InitializeComponent();
            CDMEmployees = new DMEmployees();
            SetDataSources();
        }

        /// <summary>
        /// Used for look ups 
        /// </summary>
        public void SetDataSources()
        {
            EmplTypeBindSrc.DataSource = CDMEmployees.GetEmplTypeLUps().ToList(); 
        }

        public void LoadOrInsertEmpl(int EmplID)
        {
            if (EmplID == -1)
            {
                InitNewEmpl();
            }
            else
            {
                InsertState = false;
                BindEmplByID(EmplID);
            }
        }

        private void InitNewEmpl()
        {
            InsertState = true;
            eMPLOYEESBindingSource.AddNew();
            CurrEmployee().EMPLOYEE_ID = CDMEmployees.GenID("EMPLOYEE_ID");
            CurrEmployee().EMPL_TYPE = DMStrings.EmplTypeMech;
            CurrEmployee().DATE_EMPLOYEE = DateTime.Now;
            eMPLOYEESBindingSource.ResetBindings(false);
        
        }

        private void BindEmplByID(int EmplID)
        {
            eMPLOYEESBindingSource.DataSource = CDMEmployees.CurrContex.EMPLOYEES.
                            Where(e => e.EMPLOYEE_ID == EmplID).ToList();
            CDMEmployees.CurrContex.EMPLOYEES.Attach(CurrEmployee());
        }

        public void SaveEmployeeData()
        {
            eMPLOYEESBindingSource.EndEdit();
            try
            {
                if (InsertState)
                {
                    CDMEmployees.CurrContex.Entry(CurrEmployee()).State = EntityState.Added;
                }
                else
                {
                    CDMEmployees.CurrContex.Entry(CurrEmployee()).State = EntityState.Modified;
                }
                CDMEmployees.CurrContex.SaveChanges();
                InsertState = false;
                if (ReloadFunc != null)
                    ReloadFunc();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void nAMELabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEmployeeData();
        }

        public EMPLOYEES CurrEmployee()
        {
            return (EMPLOYEES)eMPLOYEESBindingSource.Current;
        }
    }
}
