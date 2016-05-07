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
    public class DMReports
    {
        public CarShopEntities CurrContex;

        public DMReports()
        {
            CurrContex = new CarShopEntities();
        }

        public DbSet<SERVICE_WORKS> GetServiceDBSet()
        {
            return CurrContex.SERVICE_WORKS;
        }

        public void LoadCarServicesByID(int ClientCar)
        {
            var CarServices = CurrContex.SERVICE_WORKS.Where(sw => sw.APPOITMENTS.CLIENT_CAR_ID == ClientCar
                                                        && sw.APPOITMENTS.APP_STATUS != DMStrings.AppStatusCancel )
                .Include(sw => sw.SERVICES);
            CurrContex.SERVICE_WORKS.Local.Clear();
            foreach(SERVICE_WORKS CurrWork in CarServices)
            {
                CurrContex.SERVICE_WORKS.Local.Add(CurrWork);
                CurrContex.Entry(CurrWork).State = EntityState.Unchanged;
            }
        
        }
        public IQueryable<Clients> GetAllClients()
        {
            return CurrContex.Clients;
        }

        public IQueryable<CLIENT_CARS> GetAllCars()
        {
            return CurrContex.CLIENT_CARS.Include(c => c.Models).Include(c => c.LOOKUP_ITEMS);
        }



    }
}
