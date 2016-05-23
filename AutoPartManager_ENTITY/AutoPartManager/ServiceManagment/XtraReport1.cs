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
using System.Diagnostics;
using NLog;
using AutoPartDataModels;
using DataManagment;
using DevExpress.XtraReports.UI;

namespace ServiceManagment
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        DMAppointments CDMAppoitm;
        public XtraReport1()
        {
            InitializeComponent();
            CDMAppoitm = new DMAppointments();
        }

        public void Test(int AppID)
        {
            AppBindSrc.DataSource = CDMAppoitm.LoadAppByID(AppID).ToList();
            AppBindSrc.ResetBindings(false);
            CalcPriceBindSrc.DataSource = CDMAppoitm.CurrContex.FUN_CALC_APP_SUM_BY_APP_ID(AppID).ToList();
            CalcPriceBindSrc.ResetBindings(false);
            
        }
    }
}
