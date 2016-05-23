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
    public class DMParts
    {
        public CarShopEntities CurrContex;

        public int GenID(string GenName)
        {
            ObjectParameter NewValue = new ObjectParameter("nEW_VALUE", typeof(int));
            int? Step = 1;
            CurrContex.SP_GEN_ID(GenName, Step, NewValue);
            return Convert.ToInt32(NewValue.Value);
        }
        public DMParts()
        {
            CurrContex = new CarShopEntities();
        }

        public DbSet<Parts> GetPartsDBSet()
        {
            return CurrContex.Parts;
        }

        public void LoadParts(int ModelID, int SubModelID)
        {

            CurrContex.Dispose();
            CurrContex = new CarShopEntities();
            CurrContex.Parts.Where(p => p.Model_ID == ModelID && p.SUB_MODEL_ID == SubModelID).Load();

        }
        public ObservableCollection<T> ToObservableCollection<T>(IEnumerable<T> enumeration)
        {
            return new ObservableCollection<T>(enumeration);
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
