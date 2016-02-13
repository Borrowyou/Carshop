using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceProcess;
using System.Configuration;
using System.Configuration.Install;
using PartCrawler;

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
           try
            {
                string Service = "Service";
               Logger.Info("Starting Service", Service);
                 var Upd = new Thread(() =>
                {
                    Logger.Info("Updater start", Service);
                    UpdateDBData DbUpdater = new UpdateDBData();
                    DbUpdater.UpdateAll();

                });
                Upd.SetApartmentState(ApartmentState.STA);
                Upd.Start();
               // Upd.Join();
                Logger.Info("Updater started", Service);

                Logger.Info("Trying to start WCF", Service); 

                var th = new Thread(() =>
                {   
                    Logger.Info("WCF Service starting", Service);
                    ServiceBase.Run(new PartsWindowsService());
                    
                });
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                
                Logger.Info("WCF Service started", Service);
                var PartsThrd = new Thread(() =>
                {
                    Logger.Info("Part info working", Service);
                    PartCrawler.PartCrawler PartCrwl = new PartCrawler.PartCrawler();
                    PartCrwl.GetAllPagesInfo();
                });
                PartsThrd.SetApartmentState(ApartmentState.STA);
                PartsThrd.Start();
                Logger.Info("Finished starting parts info ", Service);
                 var AB = new Thread(() =>
                 {
                     Logger.Info("Crawler starting", Service);
                     PartLinkCrawler PartLinkCr = new PartLinkCrawler();
                     PartLinkCr.GetAllPartLinks();
                 });
                 AB.SetApartmentState(ApartmentState.STA);
                 AB.Start();
                 Logger.Info("Crawler started", Service);

                 Logger.Info("Part info trying to start", Service);

            }
            catch (Exception ex)
            {
                Logger.Error(ex, "MyApp");
            }
        }

        protected override void OnStart(string[] args)
        {
            Logger.Info("Starting WIndows Serivce", "Service");
            if (serviceHost != null)
            {
                serviceHost.Close();
            }
            serviceHost = new ServiceHost(typeof(PartsService));
            serviceHost.Open();
            Logger.Info("Opened WcfParts ", "Service");
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
            Logger.Info("Closed WcfParts ", "Service");
        }
    }
}
