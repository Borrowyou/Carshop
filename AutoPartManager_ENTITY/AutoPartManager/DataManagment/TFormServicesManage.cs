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
using NLog;
using AutoPartDataModels;
namespace DataManagment
{
    public partial class TFormServicesManage : Form
    {
        DMServices CDMServices;
        Logger logger;
        public TFormServicesManage()
        {
            InitializeComponent();
            CDMServices = new DMServices();
        }

        private void TFormServicesManage_Load(object sender, EventArgs e)
        {
            LoadAndBindServices();
            logger = LogManager.GetCurrentClassLogger();
        }

        private void LoadAndBindServices()
        {
            try
            {
                CDMServices.CurrContex.SERVICES.Load();
                sERVICEBindingSource.DataSource = CDMServices.CurrContex.SERVICES.Local.ToBindingList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


         }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            sERVICEBindingSource.AddNew();
            ((SERVICES)sERVICEBindingSource.Current).SERVICE_ID = CDMServices.GenID("SERVICE_ID");
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sERVICEBindingSource.EndEdit();
                CDMServices.CurrContex.SaveChanges();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            CDMServices.CurrContex.SERVICES.Load();
            gridViewServices.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
