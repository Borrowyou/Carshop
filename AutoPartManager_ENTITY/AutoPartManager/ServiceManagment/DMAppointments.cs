using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using AutoPartDataModels;

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
            return CurrContex.CLIENT_CARS.Where(b => b.CLIENT_ID == ClientID).Include(m => m.Models);
 
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
            CurrContex.APPOITMENTS.Local.Clear();
            var AllAppoitments = CurrContex.APPOITMENTS.Include(a => a.Clients).Include(a => a.SERVICE_WORKS)
                                .Include(a =>a.CLIENT_CARS.Models);
            foreach (APPOITMENTS CurrApp in AllAppoitments)
                CurrContex.APPOITMENTS.Local.Add(CurrApp);
        }

        public IQueryable<APPOITMENTS> LoadAppByID(int AppID)
        {
            return CurrContex.APPOITMENTS.Where(a => a.APPOITMENT_ID == AppID)
                .Include(a => a.SERVICE_WORKS)
                .Include(a => a.SERVICE_WORKS.Select(sv => sv.EMPLOYEES_SERVICE_WORKS))
                .Include(a => a.SERVICE_WORKS.Select(sp => sp.SERVICE_WORK_PARTS));
        }

        public void LoadServices()
        {
            var ServicesWorks = CurrContex.SERVICE_WORKS.Include(s => s.SERVICES)
                                .Include(s => s.APPOITMENTS.Clients)
                                .Include(s => s.APPOITMENTS.CLIENT_CARS.Models);
            foreach (SERVICE_WORKS CurrWork in ServicesWorks)
                CurrContex.SERVICE_WORKS.Local.Add(CurrWork);

        }
    }
}
