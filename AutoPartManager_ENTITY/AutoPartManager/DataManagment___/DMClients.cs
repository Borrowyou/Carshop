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

        public DbSet<Clients> GetClients() 
        {
            return CurrContex.Clients;
        }

        public void LoadAllClients()
        {
            CurrContex.Clients.Where(c => c.CLIENT_TYPE != DMStrings.ClientEmplType).Load();
        }
        

    }
}
