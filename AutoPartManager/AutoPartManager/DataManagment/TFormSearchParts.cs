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
    public partial class TFormSearchParts : Form
    {
        TFormManagePart FormManagePart;
        public TFormSearchParts()
        {
            InitializeComponent();
            CommonDataSet = PartsDataSet.CommonDataSet;
        }

        private void TFormSearchParts_Load(object sender, EventArgs e)
        {

            FormManagePart = new TFormManagePart(PartsDataSet);
            FormManagePart.TopLevel = false;
            pnlFormPart.Controls.Add(FormManagePart);
            PartsDataSet.SetEvents();
            FormManagePart.Show();
            SetDataSources();
            SrchFilterBndSrc.DataSource = PartsDataSet;
            CommonDataSet.LoadAllCarMarks();

            this.PartsDataSet.LoadAllParts();

        }

        private void AllPartsBindSrc_PositionChanged(object sender, EventArgs e)
        {
            if (AllPartsBindSrc.Position >= 0)
                PartsDataSet.LoadPartByID((int)PartsDataSet.ModelParts.Rows[AllPartsBindSrc.Position]["PART_ID"]);
        }

        private void SetDataSources()
        {
            CarsBindSrc.DataSource = CommonDataSet;
            ModelsBindSrc.DataSource = CommonDataSet;
        }

        private void CarsBindSrc_PositionChanged(object sender, EventArgs e)
        {

        }

        private void SrchFilterBndSrc_CurrentChanged(object sender, EventArgs e)
        {
            ;
        }

        private void SrchFilterBndSrc_CurrentItemChanged(object sender, EventArgs e)
        {
            ;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
