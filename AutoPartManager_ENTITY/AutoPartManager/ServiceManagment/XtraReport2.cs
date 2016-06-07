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
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        DMAppointments CDMAppoitments;
        public XtraReport2()
        {
            InitializeComponent();
            CDMAppoitments = new DMAppointments();
        }
        public void LoadInvoiceData(int AppID)
        {
            AppBindSrc.DataSource = CDMAppoitments.LoadAppByID(AppID).ToList();
            ProviderBindSrc.DataSource = CDMAppoitments.GetMainFirm();
            InvoiceBindSrc.DataSource = CDMAppoitments.GetInvoiceDataByAppID(AppID).ToList();
            InvoiceTotalSumBindSrc.DataSource = CDMAppoitments.GetAppTotalSum(AppID);
            

        }
        public void SetOuterData(DateTime InvDate, string InvoiceID, string PaymentWay, string Creator, string SumSpelled, string Reciever)
        {
            xrInvoiceID.Text = InvoiceID  + " / "+ InvDate.ToShortDateString();
            xrTableSumSpell.Text = xrTableSumSpell.Text + SumSpelled;
            xrTableCellDateCreate.Text = xrTableCellDateCreate.Text + InvDate.ToShortDateString();
            xrTableCellCreator.Text = xrTableCellCreator.Text +  Creator;
            xrTableCellPaymentWay.Text = xrTableCellPaymentWay.Text + PaymentWay;
            xrReciever.Text = xrReciever.Text + Reciever;
        }
        public void SetOriginal()
        { 
            xrInvoice.Text = xrInvoice.Text + " ОРИГИНАЛ";
        }




    }
}
