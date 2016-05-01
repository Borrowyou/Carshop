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
    public class DMParts
    {
        public CarShopEntities CurrContex;
        public DMParts()
        {
            CurrContex = new CarShopEntities();
        }

        public DbSet<Parts> GetPartsDBSet()
        {
            return CurrContex.Parts;
        }

        public void LoadParts(int ModelID)
        {
            var AllParts = CurrContex.Parts.Where(p => p.Model_ID == ModelID);
            CurrContex.Parts.Local.Clear();
            foreach (Parts CurrPart in AllParts)
                CurrContex.Parts.Local.Add(CurrPart);

        }
    }
}
