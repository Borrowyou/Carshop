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
            FormManagePart = new TFormManagePart();
            FormManagePart.TopLevel = false;
            FormManagePart.ReloadFunc = RefreshGrid;
            pnlForm.Controls.Add(FormManagePart);
            FormManagePart.Show();
            SetDataSources();
        }

        public TFormSearchParts(int CarID, int ModelID, int SubModelID)
        {
            InitializeComponent();
            CDMParts = new DMParts();
            lookUpMarks.EditValue = CarID;
            LookUpModels.EditValue = ModelID;
            LupYearList.EditValue = SubModelID;
            FormManagePart = new TFormManagePart();
            FormManagePart.TopLevel = false;
            FormManagePart.ReloadFunc = RefreshGrid;
            pnlForm.Controls.Add(FormManagePart);
            FormManagePart.Show();
            SetDataSources();
            AddNewPart();
        }

        public void RefreshGrid()
        {
            CDMParts.LoadParts(CurrSelModel(), CurrSelSubModel());
            partsBindingSource.DataSource = CDMParts.GetPartsDBSet().Local.ToBindingList();
        }
        private void TFormSearchParts_Load(object sender, EventArgs e)
        {
 
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

        private int CurrSelSubModel()
        {
            if (LupYearList.EditValue == null)
                return 0;
            else
                return (int)LupYearList.EditValue;
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
            RefreshGrid();
        }

        private void lookUpMarks_EditValueChanged(object sender, EventArgs e)
        {
            int SelMark = CurrSelMark();
            ModelsBindSrc.DataSource = CDMParts.CurrContex.Models.Where(m => m.CAR_ID == SelMark).ToList();
        }

        private void partsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (CurrSeletcedPart() != null)
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
                if (CurrSeletcedPart() != null)
                    PartID = CurrSeletcedPart().Part_ID;
                Close();
            }
        }

        private void btnADd_Click(object sender, EventArgs e)
        {
            AddNewPart();
        }

        private void AddNewPart()
        {
            int MarkID = Convert.ToInt32(lookUpMarks.EditValue);
            int ModelID = Convert.ToInt32(LookUpModels.EditValue);
            int SubModelID = Convert.ToInt32(LupYearList.EditValue);
            FormManagePart.LoadOrInsertPart(-1, MarkID, ModelID, SubModelID);
        }

        private void ModelsBindSrc_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        public Models CurrModel()
        {
            return (Models)ModelsBindSrc.Current;
        }

        private void LookUpModels_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpModels.EditValue != null)
            {
                int ModelID = Convert.ToInt32(LookUpModels.EditValue);
                SubModelBindSrc.DataSource = (from subm in CDMParts.CurrContex.SUB_MODELS
                                              where subm.MODEL_ID == ModelID
                                              select new
                                              {
                                                  SubModel = subm.SUB_MODEL_ID,
                                                  Yearlist = subm.YEAR_MANUF + " - " + subm.YEAR_STOP
                                              }).ToList();
            }

        }

        private void LupYearList_EditValueChanged(object sender, EventArgs e)
        {
            int SubModel = Convert.ToInt32(LupYearList.EditValue);
        }

    }
}
