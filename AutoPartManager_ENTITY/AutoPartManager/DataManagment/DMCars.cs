using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using AutoPartDataModels;

namespace DataManagment
{
    public class DMCars
    {
        public CarShopEntities CurrContex;

        public int GenID(string GenName)
        {
            ObjectParameter NewValue = new ObjectParameter("nEW_VALUE", typeof(int));
            int? Step = 1;
            CurrContex.SP_GEN_ID(GenName, Step, NewValue);
            return Convert.ToInt32(NewValue.Value);
        }
        public DMCars()
        {
            CurrContex = new CarShopEntities();
        }

        public IQueryable<Cars> GetAllCars()
        {
            return CurrContex.Cars;
        }

        public IQueryable<Models> GetModelsByCarID(int? CarID)
        {
            return CurrContex.Models.Where(m => m.CAR_ID == CarID);
        }
    }
}
