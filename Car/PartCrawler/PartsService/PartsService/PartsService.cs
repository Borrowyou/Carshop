namespace WinPartsService.ServiceModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using System.ServiceModel;
    using System.ServiceProcess;
    using System.Configuration;
    using System.Configuration.Install;

    class PartsService: IParts
    {
        public string UpdatePartByID(int iPartID)
        {
            return "Updated";
        }
    }
}
