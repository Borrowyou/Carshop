using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ServiceManagment
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport3()
        {
            InitializeComponent();
        }

        public void SetOuterData(int AppID, DateTime InvDate, string InvoiceID, string PaymentWay, string Creator, string SumSpelled, string Reciever)
        {
            XtraReport2 Rep = new XtraReport2();
            Rep.LoadInvoiceData(AppID);
            Rep.SetOuterData(InvDate, InvoiceID, PaymentWay, Creator, SumSpelled, Reciever);
            XtraReport2 RepC = new XtraReport2();
            RepC.LoadInvoiceData(AppID);
            RepC.SetOuterData(InvDate, InvoiceID, PaymentWay, Creator, SumSpelled, Reciever);
            XtraReport2 RepO = new XtraReport2();
            RepO.LoadInvoiceData(AppID);
            RepO.SetOuterData(InvDate, InvoiceID, PaymentWay, Creator, SumSpelled, Reciever);
            RepO.SetOriginal();
            int CurrH = PageHeight;
            int RepH = Rep.PageHeight;
            if (RepH * 2 > CurrH)
                Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            xrSubreport1.ReportSource = Rep;
            xrSubreport2.ReportSource = RepC;
            xrSubreport3.ReportSource = RepO;
        }

    }
}
