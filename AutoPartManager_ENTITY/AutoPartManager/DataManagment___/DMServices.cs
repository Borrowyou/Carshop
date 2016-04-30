using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using AutoPartDataModels;

namespace DataManagment
{
    public class DMServices
    {
        public CarShopEntities CurrContex;
        public DMServices()
        {
            CurrContex = new CarShopEntities();
        }

        public int GenID(string GenName)
        {
            ObjectParameter NewValue = new ObjectParameter("nEW_VALUE", typeof(int));
            int? Step = 1;
            CurrContex.SP_GEN_ID(GenName, Step, NewValue);
            return Convert.ToInt32(NewValue.Value);
        }

        public DbSet<SERVICES> GetAllServices() 
        {
            return CurrContex.SERVICES;
        }
        public void AddOrUpdateService(SERVICES ServiceObj, bool Update)
        {
            if (Update)
                CurrContex.Entry(ServiceObj).State = EntityState.Modified;
            else
                CurrContex.Entry(ServiceObj).State = EntityState.Added;
            
        }
        
    }
}
