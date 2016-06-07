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
using System.IO;

namespace ServiceManagment
{
    public partial class FormAppoitmentInvoice : Form
    {
        DMAppointments CDMAppoitments;
        int FAppID;
        Boolean InvoiceGen;
        public FormAppoitmentInvoice()
        {
            InitializeComponent();
            CDMAppoitments = new DMAppointments();
            PaymWayBindSrc.DataSource = CDMAppoitments.GetPaymTypes().ToList();
            PaymWayBindSrc.MoveFirst();
            lookUpEdit1.EditValue = ((LOOKUP_ITEMS)PaymWayBindSrc.Current).ITEM_NAME;
     
            txtEditCreator.Text = "Невена Иванова";
        }

        public void SetAppData(int AppID)
        {
            FAppID = AppID;
            Clients CurrClient = CDMAppoitments.ClientByAppID(FAppID);
            FUN_INVOICE_TOTAL_SUM_BY_APP_ID_Result TotalSum = CDMAppoitments.GetAppTotalSum(FAppID).FirstOrDefault();
            dateEdit1.EditValue = DateTime.Now;
            txtEditReciever.Text = CurrClient.MON;
            if (TotalSum != null)
            {
                lblTotalSum.Text = Convert.ToString(TotalSum.TOTAL_PRICE);
                textEdit2.Text = NumberToEnglish.changeCurrencyToWords(Convert.ToDouble(TotalSum.TOTAL_PRICE));
            }
            textEdit1.EditValue = CDMAppoitments.GetLastInvoiceID() + 1;

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GenInvoice();
  
        }


        private void GenInvoice()
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Invoices");
            string SavePath = AppDomain.CurrentDomain.BaseDirectory + @"\Invoices\" + "Invoice " + DateTime.Now.ToString("hh.mm.ss.ffffff") + ".pdf";
            if (SavePath != "")
            {
                XtraReport3 Rep = new XtraReport3();
                string InvZeroFormatted = Convert.ToInt32(textEdit1.EditValue).ToString("D10");
                Rep.SetOuterData(FAppID, Convert.ToDateTime(dateEdit1.EditValue), InvZeroFormatted, Convert.ToString(lookUpEdit1.EditValue), txtEditCreator.Text, textEdit2.Text,
                                txtEditReciever.Text);
                Rep.ExportToPdf(SavePath);
                Process.Start(SavePath);
                InvoiceGen = true;
            }
        }

        private void FormAppoitmentInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (InvoiceGen && MessageBox.Show("Активна ли е фактурата?", "Активна ли е фактурата?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                CDMAppoitments.UpdateInvoiceGenID(Convert.ToInt32(textEdit1.EditValue));
                

        }
        
    }
}
