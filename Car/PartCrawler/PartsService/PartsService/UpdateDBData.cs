using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car;

namespace PartCrawler
{
    class UpdateDBData
    {
        public void UpdateAll()
        {
            ModelSearcher ModelSearch = new ModelSearcher();
            ModelSearch.CycleMarksAndGetModels();
            CategorySearcher CategSearch = new CategorySearcher();
            CategSearch.GetAllCategories();

        }

    }
}
