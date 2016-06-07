using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoPartDataModels;

namespace DataManagment
{
    public partial class FormManageMarkAndModels : Form
    {
        DMCars CDMCars;
        public FormManageMarkAndModels()
        {
            InitializeComponent();
            CDMCars = new DMCars();
            CarBindSrc.AddNew();
            ModelBindSrc.AddNew();
            SubModelBindSrc.AddNew();
            AllMarksBindSrc.DataSource = CDMCars.GetAllCars().ToList();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveMark_Click(object sender, EventArgs e)
        {
            CarBindSrc.EndEdit();
            
            CurrCar().Car_ID = CDMCars.GenID("Cars");
            CDMCars.CurrContex.Cars.Add(CurrCar());
            CDMCars.CurrContex.SaveChanges();
            MessageBox.Show("Успешно запазено");
            CarBindSrc.AddNew();
            AllMarksBindSrc.DataSource = CDMCars.GetAllCars().ToList();
        }

        private void SetDataSourcesAndLoadData()
        {
            
            
        }

        private Cars CurrCar()
        {
            return ((Cars)CarBindSrc.Current);
        }

        private Models CurrModel()
        {
            return ((Models)ModelBindSrc.Current);
        }

        private SUB_MODELS CurrSubModel()
        {
            return ((SUB_MODELS)SubModelBindSrc.Current);
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            int CarID = Convert.ToInt32(lookUpEdit2.EditValue);
            if (CarID > 0)
                AllModelsBindSrc.DataSource = CDMCars.GetModelsByCarID(CarID).ToList();
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            
            CurrModel().MODEL_ID = CDMCars.GenID("Models");
            ModelBindSrc.EndEdit();
            CDMCars.CurrContex.Models.Add(CurrModel());
            CDMCars.CurrContex.SaveChanges();
            MessageBox.Show("Успешно запазено");
            ModelBindSrc.AddNew();
            

        }

        private void BtnSaveSubModel_Click(object sender, EventArgs e)
        {
            
            CurrSubModel().SUB_MODEL_ID = CDMCars.GenID("SUBMODELS");
            SubModelBindSrc.EndEdit();
            CDMCars.CurrContex.SUB_MODELS.Add(CurrSubModel());
            CDMCars.CurrContex.SaveChanges();
            MessageBox.Show("Успешно запазено");
            SubModelBindSrc.AddNew(); 
            
        }
    }
}
