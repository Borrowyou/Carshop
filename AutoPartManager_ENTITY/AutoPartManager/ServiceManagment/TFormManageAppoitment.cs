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
using System.IO;

namespace ServiceManagment
{
    public partial class TFormManageAppoitment : Form
    {
        DMAppointments DMAppoitm;
        Logger logger;
        FormManageClients FormMngClients;
        bool LoadData;
        public bool InsertState;

        public TFormManageAppoitment()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            DMAppoitm = new DMAppointments();
            LoadCommonData();
            InitNewAppoitment();
            SetDataSources();
            DMAppoitm.CurrContex.SERVICE_WORKS.Include(l =>l.LOOKUP_ITEMS) .Load();
            dateEdit1.EditValue = DateTime.Now;
            
        }

        public TFormManageAppoitment(bool AInsertState)
        {
            
            InitializeComponent();
            LoadData = true;
            try
            {
                InsertState = AInsertState;
                logger = LogManager.GetCurrentClassLogger();
                DMAppoitm = new DMAppointments();
                LoadCommonData();
                SetDataSources();
                DMAppoitm.CurrContex.SERVICE_WORKS.Include(l => l.LOOKUP_ITEMS).Load();
                dateEdit1.EditValue = DateTime.Now;

            }
            finally
            {
                LoadData = false;
            }


        }

        public void LoadOrInsAppt(int ApptID)
        {
            LoadData = true;
            try
            {
                if (ApptID == -1)
                {
                    InsertState = true;
                    InitNewAppoitment();
                }
                else
                {
                    InsertState = false;
                    LoadAppotimentByID(ApptID);
                }
                sERVICE_WORKSBindingSource.MoveFirst();
                BestFitAll();
            }

            finally
            {
                LoadData = false;
            }
        }

        private void LoadAppotimentByID(int ApptID)
        {
            var test = DMAppoitm.LoadAppByID(ApptID).ToList();
            aPPOITMENTBindingSource.DataSource = test;
            sERVICE_WORKSBindingSource.DataSource = CurrAppoitment().SERVICE_WORKS.ToList() ;
            CalcCurrentSum();
        }
        public void LoadCommonData()
        {
            sERVICESBindingSource.DataSource = DMAppoitm.CurrContex.SERVICES.ToList();
            lOOKUP_ITEMSBindingSource.DataSource = DMAppoitm.CurrContex.LOOKUP_ITEMS
                                        .Where(l => l.LOOKUP_NAME == DMStrings.ServiceWorkStatuses).ToList();
        }

        public void InitNewAppoitment()
        {
            aPPOITMENTBindingSource.AddNew();
            ((APPOITMENTS)aPPOITMENTBindingSource.Current).APPOITMENT_ID = DMAppoitm.GenID("APPOITMENTS_ID");
            ((APPOITMENTS)aPPOITMENTBindingSource.Current).APPOITMENT_DATE = DateTime.Now;
            ((APPOITMENTS)aPPOITMENTBindingSource.Current).APP_STATUS = DMStrings.AppStatusActive;

        }

        public void ReloadAllClients()
        {
            clientBindingSource.DataSource = DMAppoitm.GetAllClients().ToList();

        }

        public void SetDataSources()
        {
            clientBindingSource.DataSource = DMAppoitm.GetAllClients().ToList();
            //sERVICE_WORKSBindingSource.DataSource = DMAppoitm.CurrContex.SERVICE_WORKS.Local.ToBindingList();
            EmpListBindSrc.DataSource = DMAppoitm.CurrContex.EMPLOYEES.ToList();
            MeasuresBindSrc.DataSource = DMAppoitm.GetMEasures().ToList();
        }

        private void aPPOITMENTBindingSource_PositionChanged(object sender, EventArgs e)
        {
        }

        private void aPPOITMENTBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            int ClientID = ((APPOITMENTS)aPPOITMENTBindingSource.Current).CLIENT_ID;
            cLIENT_CARSBindingSource.DataSource = DMAppoitm.GetAllClients_Cars(ClientID).ToList();

        }

        public void LoadAppClientCars()
        {
            int ClientID = ((APPOITMENTS)aPPOITMENTBindingSource.Current).CLIENT_ID;
            cLIENT_CARSBindingSource.DataSource = DMAppoitm.GetAllClients_Cars(ClientID).ToList();

        }
        private void Save(Boolean Alert = false)
        {

            if (IsAppoitmentValid())
            {
                aPPOITMENTBindingSource.EndEdit();
                sERVICE_WORKSBindingSource.EndEdit();
                if (InsertState)
                {

                    DMAppoitm.CurrContex.APPOITMENTS.Add(CurrAppoitment());
                    DMAppoitm.CurrContex.Entry(CurrAppoitment()).State = EntityState.Added;
                }
                else
                {
                    DMAppoitm.CurrContex.APPOITMENTS.Attach(((APPOITMENTS)aPPOITMENTBindingSource.Current));
                    DMAppoitm.CurrContex.Entry(CurrAppoitment()).State = EntityState.Modified;
                }
                InsertState = false;
                var Stats = DMAppoitm.CurrContex.Entry(CurrAppoitment()).State;
                DMAppoitm.CurrContex.SaveChanges();
                if (Alert)
                    MessageBox.Show("Усшешно запазено!", "Запазено");
            }
      
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void aPPOITMENTBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormMngClients = new FormManageClients();
            FormMngClients.FormBorderStyle = FormBorderStyle.Sizable;
            FormMngClients.LoadOrInsertClient(-1);
            FormMngClients.ShowDialog();
            CurrAppoitment().CLIENT_ID = FormMngClients.FClientID;
            ReloadAllClients();
            aPPOITMENTBindingSource.ResetBindings(false);
            
        }

        public APPOITMENTS CurrentAppoitment()
        {
            return (APPOITMENTS)aPPOITMENTBindingSource.Current;
        }

        private void btnAddServiceWork_Click(object sender, EventArgs e)
        {
            LoadData = true;
            try
            {
                sERVICE_WORKSBindingSource.AddNew();
                ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).SERVICE_WORK_ID = DMAppoitm.GenID("SERVICE_WORK_ID");
                ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).APPOITMENT_ID = ((APPOITMENTS)aPPOITMENTBindingSource.Current).APPOITMENT_ID;
                ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).WORK_STATUS = DMStrings.ServiceWorkPend;
                CurrentServiceWork().QUANTITY = 1;
                CurrentServiceWork().INCLUDE_INVOICE = "Y";
                CurrentServiceWork().MEASURE = DMStrings.MeasWorkHours;
                CurrAppoitment().SERVICE_WORKS.Add(CurrentServiceWork());
            }
            finally
            {
                LoadData = false;
            }

        }
        private SERVICE_WORKS CurrentServiceWork()
        {
            return (SERVICE_WORKS)sERVICE_WORKSBindingSource.Current;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Save(true);
            CalcCurrentSum();
        }

        private void btnAddNewWorker_Click(object sender, EventArgs e)
        {
            EmplSrvBindingSrc.AddNew();
            CurrEmplWork().EMPLOYEE_WORK_ID = DMAppoitm.GenID("EMPLOYEE_WORKS");
            CurrEmplWork().SERVICE_WORK_ID = CurrentServiceWork().SERVICE_WORK_ID;
            CurrentServiceWork().EMPLOYEES_SERVICE_WORKS.Add(CurrEmplWork());  
        }

        private EMPLOYEES_SERVICE_WORKS CurrEmplWork()
        {
            return (EMPLOYEES_SERVICE_WORKS)EmplSrvBindingSrc.Current;
        }

        private void sERVICE_WORKSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (CurrentServiceWork() != null)
            {
                EmplSrvBindingSrc.DataSource = CurrentServiceWork().EMPLOYEES_SERVICE_WORKS.ToList();
                ServicePartsBindSrc.DataSource = CurrentServiceWork().SERVICE_WORK_PARTS.ToList();
            }

        }

        private void LoadEmplServices()
        { 
            
        }

        private APPOITMENTS CurrAppoitment()
        {
            return (APPOITMENTS)aPPOITMENTBindingSource.Current;
        }

        private void sERVICE_WORKSBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void sERVICE_WORKSBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        

        }

        public void SetClientID(int ClientID)
        {
            gridLookUpEdit1.EditValue = ClientID;
        }

     
        private void btnRemoveServWork_Click(object sender, EventArgs e)
        {
            if (CurrentServiceWork() != null)
            {
                var EmplWorkList = CurrentServiceWork().EMPLOYEES_SERVICE_WORKS.ToList();
                foreach (EMPLOYEES_SERVICE_WORKS EmplWork in EmplWorkList)
                {
                    MarkAndDElEmplWork(EmplWork);
                }
                foreach (SERVICE_WORK_PARTS ServWorkPart in CurrentServiceWork().SERVICE_WORK_PARTS.ToList())
                {
                    MarkAndDElServWorPartk(ServWorkPart);
                }

                if (DMAppoitm.CurrContex.Entry(CurrentServiceWork()).State != EntityState.Added && DMAppoitm.CurrContex.Entry(CurrentServiceWork()).State != EntityState.Detached)
                {

                    CurrAppoitment().SERVICE_WORKS.Remove(CurrentServiceWork());
                    DMAppoitm.CurrContex.Entry(CurrentServiceWork()).State = EntityState.Deleted;
                }
                else
                {

                    CurrAppoitment().SERVICE_WORKS.Remove(CurrentServiceWork());
                    DMAppoitm.CurrContex.Entry(CurrentServiceWork()).State = EntityState.Detached;
                }
                sERVICE_WORKSBindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnAddNewPart_Click(object sender, EventArgs e)
        {
            ServicePartsBindSrc.AddNew();
            CurrWorkPart().WORK_PART_ID = DMAppoitm.GenID("SERVICE_WORK_PART");
            CurrentServiceWork().SERVICE_WORK_PARTS.Add(CurrWorkPart());

        }

        private CLIENT_CARS CurrClCar()
        {
            int CurrCarID = CurrAppoitment().CLIENT_CAR_ID;
            CLIENT_CARS CurrCar = DMAppoitm.CurrContex.CLIENT_CARS.FirstOrDefault(cl => cl.CLIENT_CAR_ID ==
                                CurrCarID);
            return CurrCar;
        }

        private SERVICE_WORK_PARTS CurrWorkPart()
        {
            return (SERVICE_WORK_PARTS)ServicePartsBindSrc.Current;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            TFormSearchParts FormSrchParts = new TFormSearchParts(CurrClCar().CAR_ID, CurrClCar().MODEL_ID, CurrClCar().SUB_MODEL_ID);
            FormSrchParts.FormBorderStyle = FormBorderStyle.Sizable;
            FormSrchParts.RefreshGrid();
            FormSrchParts.WindowState = FormWindowState.Maximized;
            FormSrchParts.ShowDialog();
            int PartID = FormSrchParts.PartID;
            if (PartID > 0)
            {
                ServicePartsBindSrc.AddNew();
                CurrWorkPart().WORK_PART_ID = DMAppoitm.GenID("SERVICE_WORK_PART");
                CurrWorkPart().PART_ID = PartID;
                CurrWorkPart().Parts = DMAppoitm.GetPartByID(PartID);
                CurrWorkPart().PART_PRICE = CurrWorkPart().Parts.part_price;
                CurrWorkPart().INCLUDE_INVOICE = "Y";
                CurrWorkPart().QUANTITY = 1;
                CurrWorkPart().TOTAL_PRICE = CurrWorkPart().QUANTITY * CurrWorkPart().PART_PRICE;
                CurrWorkPart().DISPL_MANUF_WORK_CARD = "N";
                CurrWorkPart().MEASURE = DMStrings.MeasNumb;
                CurrentServiceWork().SERVICE_WORK_PARTS.Add(CurrWorkPart());
                ServicePartsBindSrc.ResetBindings(false);
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string SavePath = folderBrowserDialog1.SelectedPath + "\\" + DateTime.Now.ToShortDateString() + ".pdf";
            if (SavePath != "")
            {
                fUN_CALC_APP_SUM_BY_APP_ID_ResultGridControl.ExportToPdf(SavePath);
                Process.Start(SavePath);
            }
            fUN_CALC_APP_SUM_BY_APP_ID_ResultGridControl.ExportToHtml(SavePath);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Save();
            CalcCurrentSum();
        }
        private void CalcCurrentSum()
        {
            fUN_CALC_APP_SUM_BY_APP_ID_ResultBindingSource.DataSource = DMAppoitm.CurrContex.FUN_CALC_APP_SUM_BY_APP_ID(
                                            CurrAppoitment().APPOITMENT_ID).ToList();
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SERVICE_ID")
            {
                CurrentServiceWork().WORK_PRICE = DMAppoitm.CurrContex.SERVICES.
                                            Find(CurrentServiceWork().SERVICE_ID).PRICE_PER_HOUR; 
                sERVICE_WORKSBindingSource.ResetCurrentItem();
            }
            if (e.Column.FieldName == "WORK_PRICE" || e.Column.FieldName == "QUANTITY")
            {
                CurrentServiceWork().TOTAL_PRICE = CurrentServiceWork().QUANTITY * CurrentServiceWork().WORK_PRICE;
            }


            if (e.Column.FieldName == "WORK_STATUS")
            {
                if (CurrentServiceWork().WORK_STATUS == DMStrings.ServiceWorkStarted)
                    CurrentServiceWork().TIME_START = DateTime.Now;
                else if (CurrentServiceWork().WORK_STATUS == DMStrings.ServiceWorkFinished)
                    CurrentServiceWork().TIME_FINISH = DateTime.Now;
            }
        }

        private void BestFitAll()
        {

        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            //DMAppoitm.CurrContex.Entry(CurrEmplWork()).State = EntityState.Deleted;
            //CurrentServiceWork().EMPLOYEES_SERVICE_WORKS.Remove(CurrEmplWork());
            //EmplSrvBindingSrc.RemoveCurrent();
            MarkAndDElEmplWork(CurrEmplWork());
        }
        private void MarkAndDElEmplWork(EMPLOYEES_SERVICE_WORKS EmplWork)
        {
            if (DMAppoitm.CurrContex.Entry(EmplWork).State != EntityState.Added && DMAppoitm.CurrContex.Entry(EmplWork).State != EntityState.Detached)
                DMAppoitm.CurrContex.Entry(EmplWork).State = EntityState.Deleted;
            else
                DMAppoitm.CurrContex.Entry(EmplWork).State = EntityState.Detached;
            
            CurrentServiceWork().EMPLOYEES_SERVICE_WORKS.Remove(EmplWork);
            EmplSrvBindingSrc.Remove(EmplWork);
        }

        private void MarkAndDElServWorPartk(SERVICE_WORK_PARTS ServPart)
        {
            if (DMAppoitm.CurrContex.Entry(ServPart).State != EntityState.Added && DMAppoitm.CurrContex.Entry(ServPart).State != EntityState.Detached)
                DMAppoitm.CurrContex.Entry(ServPart).State = EntityState.Deleted;
            else
                DMAppoitm.CurrContex.Entry(ServPart).State = EntityState.Detached;
            CurrentServiceWork().SERVICE_WORK_PARTS.Remove(ServPart);
            ServicePartsBindSrc.Remove(ServPart);
        }


        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            if (DMAppoitm.CurrContex.Entry(CurrWorkPart()).State != EntityState.Added)
                DMAppoitm.CurrContex.Entry(CurrWorkPart()).State = EntityState.Deleted;
            else
                DMAppoitm.CurrContex.Entry(CurrWorkPart()).State = EntityState.Detached;

            CurrentServiceWork().SERVICE_WORK_PARTS.Remove(CurrWorkPart());
            ServicePartsBindSrc.RemoveCurrent();
            
        }

        private void btnMarkFinished_Click(object sender, EventArgs e)
        {
            CurrAppoitment().APP_STATUS = DMStrings.AppStatusFinish;
            Save(true);
        }

        private void gridServiceParts_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Save(false);
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\WorkCars");
            string SavePath = AppDomain.CurrentDomain.BaseDirectory + @"\WorkCars\" + "WorkCard " + DateTime.Now.ToString("hh.mm.ss.ffffff") + ".pdf";
            if (SavePath != "")
            {
                XtraReport1 Rep = new XtraReport1();
                Rep.Test(CurrAppoitment().APPOITMENT_ID);
                Rep.SetWorkCardDate(Convert.ToDateTime(dateEdit1.EditValue));
                Rep.ExportToPdf(SavePath);
                Process.Start(SavePath);
            }
        }

        private void HiperLinkClients_Click(object sender, EventArgs e)
        {
            if (CurrAppoitment().CLIENT_ID > 0)
            {
                FormMngClients = new FormManageClients();
                FormMngClients.FormBorderStyle = FormBorderStyle.Sizable;
                FormMngClients.LoadOrInsertClient(CurrAppoitment().CLIENT_ID);
                FormMngClients.ShowDialog();
                ReloadAllClients();
                aPPOITMENTBindingSource.ResetBindings(false);
                cLIENT_CARSBindingSource.DataSource = DMAppoitm.GetAllClients_Cars(CurrAppoitment().CLIENT_ID).ToList();
            }
        }

        private void BtnNewService_Click(object sender, EventArgs e)
        {
            TFormServicesManage FormServManage = new TFormServicesManage();
            FormServManage.ShowDialog();
            if (FormServManage.ServiceID > 0)
            {

                LoadData = true;
                try
                {
                    sERVICE_WORKSBindingSource.AddNew();
                    ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).SERVICE_WORK_ID = DMAppoitm.GenID("SERVICE_WORK_ID");
                    ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).APPOITMENT_ID = ((APPOITMENTS)aPPOITMENTBindingSource.Current).APPOITMENT_ID;
                    ((SERVICE_WORKS)sERVICE_WORKSBindingSource.Current).WORK_STATUS = DMStrings.ServiceWorkPend;
                    CurrentServiceWork().SERVICE_ID = FormServManage.ServiceID;
                    CurrentServiceWork().QUANTITY = 1;
                    CurrentServiceWork().INCLUDE_INVOICE = "Y";
                    CurrentServiceWork().MEASURE = DMStrings.MeasWorkHours;
                    CurrentServiceWork().WORK_PRICE = DMAppoitm.CurrContex.SERVICES.
                                            Find(CurrentServiceWork().SERVICE_ID).PRICE_PER_HOUR;
                    CurrentServiceWork().TOTAL_PRICE = CurrentServiceWork().QUANTITY * CurrentServiceWork().WORK_PRICE; 
                    CurrAppoitment().SERVICE_WORKS.Add(CurrentServiceWork());
                    sERVICE_WORKSBindingSource.ResetBindings(false);
                    sERVICESBindingSource.DataSource = DMAppoitm.CurrContex.SERVICES.ToList();
                }
                finally
                {
                    LoadData = false;
                }     
            } 
        }

        private void gridViewServiceParts_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "PART_PRICE" || e.Column.FieldName == "QUANTITY")
            {
                CurrWorkPart().TOTAL_PRICE = CurrWorkPart().QUANTITY * CurrWorkPart().PART_PRICE;
            }
        }

        private void sERVICE_WORKSBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            pnlServWorkDetails.Enabled = sERVICE_WORKSBindingSource.Count > 0;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            string SavePath = AppDomain.CurrentDomain.BaseDirectory + @"\Invoices" + "Invoice " + DateTime.Now.ToString("hh.mm.ss.ffffff") + ".pdf";
            if (SavePath != "")
            {
                XtraReport2 Rep = new XtraReport2();
                Rep.LoadInvoiceData(CurrAppoitment().APPOITMENT_ID);
                Rep.ExportToPdf(SavePath);
                Process.Start(SavePath);
            }
        }

        private void simpleButton2_Click_2(object sender, EventArgs e)
        {

            Save(false);
            FormAppoitmentInvoice FormInv = new FormAppoitmentInvoice();
            FormInv.SetAppData(CurrAppoitment().APPOITMENT_ID);
            FormInv.ShowDialog();
        }

        private bool IsAppoitmentValid()
        {
            StringBuilder ErrorList = new StringBuilder();
            if (CurrentAppoitment().CLIENT_CAR_ID == 0)
                ErrorList.AppendLine("Моля изберете кола на клиента!");
            if (CurrentAppoitment().CLIENT_ID == 0)
                ErrorList.AppendLine("Моля изберете клиент!");
            if (ErrorList.Length > 0)
                MessageBox.Show(ErrorList.ToString());
            return ErrorList.Length == 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
        
    }
}
