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
    public class DMClients
    {
        public CarShopEntities CurrContex;
        public DMClients()
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


        public DbSet<Clients> GetClientsDbSet()
        {
            return CurrContex.Clients;
        }

        public void LoadAllClients()
        {
            CurrContex.Clients.Where(c => c.CLIENT_TYPE != DMStrings.ClienTypeEmpoyee).Load();
        }

        public void LoadAllEmployees()
        {
            CurrContex.EMPLOYEES.Load();
        }

        public void LoadClientByID(int ClientID)
        {
            CurrContex.Clients.Local.Clear();
            var CurrCL = CurrContex.Clients.First(c => c.CLIENT_ID == ClientID);
            CurrContex.Clients.Local.Add(CurrCL);
        }

        public IQueryable<LOOKUP_ITEMS> GetClienTypesLookUp()
        {
            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.ClienTypesLup
                                            && l.ITEM_CODE != DMStrings.ClienTypeEmpoyee);
        }

        public IQueryable<LOOKUP_ITEMS> GetClienTypeEmployee()
        {
            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.ClienTypesLup
                                            && l.ITEM_CODE == DMStrings.ClienTypeEmpoyee);
        }

        public IQueryable<CLIENT_CARS> LoadClientCars(int ClientID)
        { 
            return CurrContex.CLIENT_CARS.Where(clc => clc.CLIENT_ID == ClientID);
        }

        public IQueryable<FUN_YEARS_BETWEEN_LIST_Result>  LoadCarYears(int? CarID, string ModelName)
        {
            var CurrentModel = from my in CurrContex.Models
                               where (my.CAR_ID == CarID && my.MODEL_NAME == ModelName)
                               group my by new { my.CAR_ID, my.MODEL_NAME } into g
                               select new
                               {
                                min = g.Min(my => my.YEAR_MANUF),
                                max = g.Max(my => my.YEAR_STOP)
                               };
            var ModelYears = CurrentModel.SingleOrDefault();
            return CurrContex.FUN_YEARS_BETWEEN_LIST(ModelYears.min, ModelYears.max);
        }

        public IQueryable<LOOKUP_ITEMS> GetEngineTypes()
        {
            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.EngTypeLup);
        }


        public IQueryable<LOOKUP_ITEMS> GetEmplTypeLUps()
        {
            return CurrContex.LOOKUP_ITEMS.Where(l => l.LOOKUP_NAME == DMStrings.EmplTypeLUp);
        }

    }
}
