using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using AutoPartDataModels;
using DataManagment;

namespace ServiceManagment
{
    public class DMAppointments
    {
        public CarShopEntities CurrContex;
        public DMAppointments()
        {
            CurrContex = new CarShopEntities();
            
        }

        public int GenID(string GenName)
        {
            ObjectParameter NewValue = new ObjectParameter("nEW_VALUE", typeof(int));
            CurrContex.SP_GEN_ID(GenName, 1, NewValue); 
            return Convert.ToInt32(NewValue.Value); 
        }

        public DbSet<Clients> GetAllClients()
        {
            return CurrContex.Clients;
        }
        public IQueryable<CLIENT_CARS> GetAllClients_Cars(int ClientID)
        {
            return CurrContex.CLIENT_CARS.Where(b => b.CLIENT_ID == ClientID).Include(m => m.Models)
                                            .Include(m =>m.LOOKUP_ITEMS);
 
        }

        public DbSet<APPOITMENTS> GetAppoitmentsDBSet()
        {
            return CurrContex.APPOITMENTS;
        }

        public DbSet<SERVICE_WORKS> GetServiceWorksDBSet()
        {
            return CurrContex.SERVICE_WORKS;
        }

        public void LoadAllAppoitments()
        {
            CurrContex.Dispose();
            CurrContex = new CarShopEntities();
            CurrContex.APPOITMENTS.Where(a => a.APP_STATUS == DMStrings.AppStatusActive)
                .Include(a => a.Clients).Include(a => a.SERVICE_WORKS)
                                .Include(a => a.CLIENT_CARS.Models)
                                .Include(a => a.CLIENT_CARS.LOOKUP_ITEMS).Load();
        }

        public IQueryable<APPOITMENTS> LoadAppByID(int AppID)
        {
            return CurrContex.APPOITMENTS.Where(a => a.APPOITMENT_ID == AppID)
                .Include(a => a.Clients).Include(a => a.CLIENT_CARS)
                .Include(a => a.CLIENT_CARS.Models).Include(a => a.CLIENT_CARS.Cars)
                .Include(a => a.CLIENT_CARS.LOOKUP_ITEMS)
                .Include(a => a.SERVICE_WORKS)
                .Include(a => a.SERVICE_WORKS.Select(sw => sw.SERVICES))
                .Include(a => a.SERVICE_WORKS.Select(sv => sv.EMPLOYEES_SERVICE_WORKS))
                .Include(a => a.SERVICE_WORKS.Select(sp => sp.SERVICE_WORK_PARTS.Select(swp => swp.Parts)));
        }

        public void LoadServices()
        {
            CurrContex.SERVICE_WORKS.Where(sw => sw.APPOITMENTS.APP_STATUS == DMStrings.AppStatusActive)
                                .Include(s => s.SERVICES)
                                .Include(s => s.APPOITMENTS.Clients)
                                .Include(s => s.APPOITMENTS.CLIENT_CARS.Models)
                                .Include(e => e.EMPLOYEES_SERVICE_WORKS).Load();


        }
        public IQueryable<LOOKUP_ITEMS> GetServiceWorkStatuses()
        {

            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.ServiceWorkStatuses);
        }

        public IQueryable<EMPLOYEES> GetMechanicsList()
        {
            return CurrContex.EMPLOYEES.Where(e => e.EMPL_TYPE == DMStrings.EmplTypeMech);
        }

        public void LoadServicesByMechAndStatus(int EmplID, string WorkStatus)
        {
            CurrContex.Dispose();
            CurrContex = new CarShopEntities();
            CurrContex.SERVICE_WORKS.Where(sw => sw.WORK_STATUS == WorkStatus
                                && sw.APPOITMENTS.APP_STATUS != DMStrings.AppStatusCancel)
                .Include(s => s.SERVICES)
                .Include(s => s.APPOITMENTS.Clients)
                .Include(s => s.APPOITMENTS.CLIENT_CARS.Models)
                .Include(e => e.EMPLOYEES_SERVICE_WORKS).Load();
            

        }

        public IQueryable<EMPLOYEES_SERVICE_WORKS> GetServWorkEmployees(int ServWorkID)
        {
            return CurrContex.EMPLOYEES_SERVICE_WORKS.Where(e => e.SERVICE_WORK_ID == ServWorkID)
                                                      .Include(ew => ew.EMPLOYEES);
        }

        public void CancelAppoitmentByID(int AppID)
        {
            var App = CurrContex.APPOITMENTS.FirstOrDefault(a => a.APPOITMENT_ID == AppID);
            App.APP_STATUS = DMStrings.AppStatusCancel;
            CurrContex.Entry(App).State = EntityState.Modified;
            CurrContex.SaveChanges();
        }

        public Parts GetPartByID(int PartID)
        {
            return CurrContex.Parts.FirstOrDefault(p => p.Part_ID == PartID);
        }
        public Clients GetMainFirm()
        {
            return CurrContex.Clients.FirstOrDefault(c => c.CLIENT_NAME.Contains("АБАРТ-2000"));
        }

        public IQueryable<FUN_INVOICE_DATA_BY_APP_ID_Result> GetInvoiceDataByAppID(int Appid)
        {
            return CurrContex.FUN_INVOICE_DATA_BY_APP_ID(Appid);
        }

        public IQueryable<LOOKUP_ITEMS> GetMEasures()
        {

            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.MeasuresCode);
        }

        public IQueryable<FUN_INVOICE_TOTAL_SUM_BY_APP_ID_Result> GetAppTotalSum(int AppID)
        {
            return CurrContex.FUN_INVOICE_TOTAL_SUM_BY_APP_ID(AppID);
        }

        public int GetLastInvoiceID()
        {
            return Convert.ToInt32(CurrContex.GENERATORS.FirstOrDefault(g => g.GENERATOR_NAME == "INVOICE").GENERATOR_VALUE);
        }

        public IQueryable<LOOKUP_ITEMS> GetPaymTypes()
        {
            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.PaymLookup);
        }

        public void UpdateInvoiceGenID(int InvoiceID)
        {
            CurrContex.GENERATORS.FirstOrDefault(g => g.GENERATOR_NAME == "INVOICE").GENERATOR_VALUE = InvoiceID;
            CurrContex.SaveChanges();
        }

        public Clients ClientByAppID(int AppID)
        {
            var App = CurrContex.APPOITMENTS.Where(a => a.APPOITMENT_ID == AppID).FirstOrDefault();
            Clients AppClient = CurrContex.Clients.Where(c => c.CLIENT_ID == App.CLIENT_ID).FirstOrDefault();
            return AppClient;
        }
    }
}
