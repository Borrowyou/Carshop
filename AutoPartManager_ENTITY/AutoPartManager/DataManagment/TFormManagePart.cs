using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoPartDataModels;
using LogExceptions;

namespace DataManagment
{
    public partial class TFormManagePart : Form
    {
        DMParts CDMParts;
        bool InsertState;
        public delegate void RefreshGrid();
        public RefreshGrid ReloadFunc;

        public TFormManagePart()
        {
            InitializeComponent();
            CDMParts = new DMParts();
            Dock = DockStyle.Fill;
            SetDataSources();
        }
        public TFormManagePart(TPartsDataSet APartsDSet)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void SetDataSources()
        {
            MarksBindSrc.DataSource = CDMParts.GetAllCars().ToList();
        }

        public void LoadOrInsertPart(int PartID, int MarkID = -1, int ModelID = -1, int SubModelID = -1)
        {
            if (PartID == -1)
            {
                InitNewPart(MarkID, ModelID, SubModelID);
            }
            else
            {
                InsertState = false;
                LoadPartByID(PartID);
            }
        
        }

        private void LoadPartByID(int PartID)
        {
            partsBindingSource.DataSource = CDMParts.CurrContex.Parts.Where(p => p.Part_ID == PartID).ToList();
        }

        private void InitNewPart(int MarkID, int ModelID, int SubModelID)
        {
            InsertState = true;
            partsBindingSource.AddNew();
            CurrPart().Part_ID = CDMParts.GenID("Parts");
            if (MarkID != -1 && ModelID != -1)
            {
                CurrPart().Car_ID = MarkID;
                CurrPart().Model_ID = ModelID;
                CurrPart().SUB_MODEL_ID = SubModelID;
            }
            partsBindingSource.ResetBindings(false);

        }


        private void TFormManagePart_Load(object sender, EventArgs e)
        {

        }


        private Parts CurrPart()
        {
            return (Parts)partsBindingSource.Current;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        
                SavePartData();

            
            
        }

        private void SavePartData()
        {
            partsBindingSource.EndEdit();

            if (InsertState)
            {
                CDMParts.CurrContex.Entry(CurrPart()).State = EntityState.Added;
            }
            else
            {
                CDMParts.CurrContex.Entry(CurrPart()).State = EntityState.Modified;
            }
            CDMParts.CurrContex.SaveChanges();
            InsertState = false;
            if (ReloadFunc != null)
                ReloadFunc();
   
        
        }

        private void partsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (CurrPart() != null)
                ModelsBindSrc.DataSource = CDMParts.GetModelsByCarID(CurrPart().Car_ID).ToList();
            if (ModelsBindSrc.Count > 0 && ((Parts)partsBindingSource.Current) != null)
            {
                int ModelID = ((Parts)partsBindingSource.Current).Model_ID.GetValueOrDefault(0);
                SubModelBindSrc.DataSource = (from subm in CDMParts.CurrContex.SUB_MODELS
                                              where subm.MODEL_ID == ModelID
                                              select new
                                              {
                                                  SubModel = subm.SUB_MODEL_ID,
                                                  Yearlist = subm.YEAR_MANUF + " - " + subm.YEAR_STOP
                                              }).ToList();
            }
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

            //if (ModelsBindSrc.Count > 0 && ((Parts)partsBindingSource.Current) != null)
            //{
            //    int ModelID = ((Parts)partsBindingSource.Current).Model_ID.GetValueOrDefault(0);
            //    SubModelBindSrc.DataSource = (from subm in CDMParts.CurrContex.SUB_MODELS
            //                                  where subm.MODEL_ID == ModelID
            //                                  select new
            //                                  {
            //                                      SubModel = subm.SUB_MODEL_ID,
            //                                      Yearlist = subm.YEAR_MANUF + " - " + subm.YEAR_STOP
            //                                  }).ToList();
            //}

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

  
        }

        private void ModelsBindSrc_CurrentItemChanged(object sender, EventArgs e)
        {

        }
    }
}
