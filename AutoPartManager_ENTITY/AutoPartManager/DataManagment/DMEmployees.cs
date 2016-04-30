using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.ComponentModel;
using AutoPartDataModels;

namespace DataManagment
{
    public class DMEmployees
    {
        public CarShopEntities CurrContex;

        public DMEmployees()
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


        public DbSet<EMPLOYEES> GetEmployeesDBSet()
        {
            return CurrContex.EMPLOYEES;
        }

        public void LoadAllEMployees()
        {
            CurrContex.EMPLOYEES.Load();
        }

        public IQueryable<LOOKUP_ITEMS> GetEmplTypeLUps()
        {
            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.EmplTypeLUp);
        }



    }
}
