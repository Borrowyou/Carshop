using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceManagment
{
    public partial class TFormManageAppoitment : Form
    {
      
        public TFormManageAppoitment()
        {
            InitializeComponent();
            CommonDataSet = AppointmentsDataset.CommonDataset;
        }

        private void TFormManageAppoitment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AppointmentsDataset.CLIENT_CARS' table. You can move, or remove it, as needed.
            this.cLIENT_CARSTableAdapter.Fill(this.AppointmentsDataset.CLIENT_CARS);
            SetDataSources();
            AppointmentsDataset.SetEvents();
            LoadCommonData();
            AppmntBindSrc.AddNew();

        }

        private void SetDataSources()
        {
            ClientsBndSrc.DataSource = CommonDataSet;
            
        }

        private void LoadCommonData()
        {
            CommonDataSet.LoadClientsList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AppmntBindSrc.EndEdit();
            AppointmentsDataset.SaveAppoitment();
        }


    }
}
