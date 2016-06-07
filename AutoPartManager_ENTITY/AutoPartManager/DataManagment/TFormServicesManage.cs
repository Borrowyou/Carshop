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
        public int ServiceID;
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
            SaveService(true);

        }
        private void SaveService(bool DoAlert)
        {
            sERVICEBindingSource.EndEdit();
            CDMServices.CurrContex.SaveChanges();
            if (DoAlert)
                MessageBox.Show("Успешно запазено");
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

        private void sERVICEGridControl_DoubleClick(object sender, EventArgs e)
        {
            if (CurrService().SERVICE_ID > 0 && Modal == true)
            {
                SaveService(false); 
                ServiceID = CurrService().SERVICE_ID;
                Close();
            }
        }

        private SERVICES CurrService()
        {
            return (SERVICES)sERVICEBindingSource.Current;
        }
    }
}
