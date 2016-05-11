using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using AutoPartDataModels;

namespace PartCrawler
{
    public class DMGenID
    {
        CarShopEntities CurrContex;
        public DMGenID()
        {
            CurrContex = new CarShopEntities();
        }

        public int GenID(string GenName)
        {
            ObjectParameter NewValue = new ObjectParameter("nEW_VALUE", typeof(int));
            try
            {
                
                CurrContex.SP_GEN_ID(GenName, 1, NewValue);

            }
            catch (Exception Ex)
            {
               
            }
            return Convert.ToInt32(NewValue.Value);

        }

    }
}
