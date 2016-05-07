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

        public void LoadOrInsertPart(int PartID)
        {
            if (PartID == -1)
            {
                InitNewPart();
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

        private void InitNewPart()
        {
            InsertState = true;
            partsBindingSource.AddNew();
            CurrPart().Part_ID = CDMParts.GenID("PART_ID");
            partsBindingSource.ResetBindings(false);

        }


        private void TFormManagePart_Load(object sender, EventArgs e)
        {

        }

        private void MarksBindSrc_CurrentItemChanged(object sender, EventArgs e)
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
            try
            {
                if (InsertState)
                {
                    CDMParts.CurrContex.Entry(CurrPart()).State = EntityState.Added;
                }
                else
                {
                    CDMParts.CurrContex.Entry(CurrPart()).State = EntityState.Modified;
                }
                CDMParts.CurrContex.SaveChanges();
                if (ReloadFunc != null)
                    ReloadFunc();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        
        }

        private void partsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (CurrPart() != null)
                ModelsBindSrc.DataSource = CDMParts.GetModelsByCarID(CurrPart().Car_ID).ToList();
        }
    }
}
