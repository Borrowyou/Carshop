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
    public partial class TFormSearchParts : Form
    {
        TFormManagePart FormManagePart;
        DMParts CDMParts;
        public int PartID;
        public TFormSearchParts()
        {
            InitializeComponent();
            CDMParts = new DMParts();
        }

        public TFormSearchParts(int CarID, int ModelID)
        {
            InitializeComponent();
            CDMParts = new DMParts();
            lookUpMarks.EditValue = CarID;
            LookUpModels.EditValue = ModelID;
            CDMParts.LoadParts(CurrSelModel()); 
        }

        private void RefreshGrid()
        {
            CDMParts.LoadParts(CurrSelModel());
        }
        private void TFormSearchParts_Load(object sender, EventArgs e)
        {
            FormManagePart = new TFormManagePart();
            FormManagePart.TopLevel = false;
            FormManagePart.ReloadFunc = RefreshGrid; 
            pnlForm.Controls.Add(FormManagePart);
            FormManagePart.Show();
            SetDataSources();
        }

        private void AllPartsBindSrc_PositionChanged(object sender, EventArgs e)
        {

        }

        private void SetDataSources()
        {
            partsBindingSource.DataSource = CDMParts.GetPartsDBSet().Local.ToBindingList();
            MarksBindSrc.DataSource = CDMParts.CurrContex.Cars.ToList();
        }

        private void MarksBindSrc_PositionChanged(object sender, EventArgs e)
        {

        }

        private int CurrSelModel()
        {
            if (LookUpModels.EditValue == null)
                return 0;
            else
                return (int)LookUpModels.EditValue;
        }
        private int CurrSelMark()
        {
            if (lookUpMarks.EditValue == null)
                return 0;
            else
                return (int)lookUpMarks.EditValue;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CDMParts.LoadParts(CurrSelModel());
        }

        private void lookUpMarks_EditValueChanged(object sender, EventArgs e)
        {
            int SelMark = CurrSelMark();
            ModelsBindSrc.DataSource = CDMParts.CurrContex.Models.Where(m => m.CAR_ID == SelMark).ToList();
        }

        private void partsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            FormManagePart.LoadOrInsertPart(CurrSeletcedPart().Part_ID);
        }

        private Parts CurrSeletcedPart()
        {
            return (Parts)partsBindingSource.Current;
        }

        private void partsGridParts_DoubleClick(object sender, EventArgs e)
        {
            if (Modal)
            {
                PartID = CurrSeletcedPart().Part_ID;
                Close();
            }
        }

        private void btnADd_Click(object sender, EventArgs e)
        {
            FormManagePart.LoadOrInsertPart(-1);
        }

    }
}
