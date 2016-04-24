using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace ServiceManagment
{
    public class DMAppointments
    {
        public CarShopEntities2 CurrContex;
        public DMAppointments()
        {
            CurrContex = new CarShopEntities2();
            
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


    }
}
