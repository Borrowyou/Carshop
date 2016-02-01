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

namespace WinPartsService.ServiceModel
{
    public class PartsWindowsService: ServiceBase
    {
        public ServiceHost serviceHost = null;
        public PartsWindowsService()
        {
            // Name the Windows Service
            ServiceName = "PartsService";
        }

        public static void Main()
        {
            ServiceBase.Run(new PartsWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }
            serviceHost = new ServiceHost(typeof(PartsService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
