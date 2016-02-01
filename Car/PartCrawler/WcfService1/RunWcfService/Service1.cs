using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfService1;
using System.ServiceModel.Description; 

namespace RunWcfService
{
    public partial class Service1 : ServiceBase
    {
        private System.Diagnostics.EventLog eventLog1;

        public Service1()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        public void InitService()
        {
            Uri baseAddress = new Uri("http://192.168.0.110:8000/GettingStarted/");

            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

            try
            { 
                // Step 3 Add a service endpoint.
             //   selfHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "Service1");

                // Step 4 Enable metadata exchange.
              //  ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
              //  smb.HttpGetEnabled = true;
            //    selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.
                selfHost.Open();
             
                // Close the ServiceHostBase to shutdown the service.
                //selfHost.Close();
                
            }
            
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                Console.ReadLine();
                selfHost.Abort();
            }
        }
        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");
            InitService();
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In OnContinue.");
        }
    }
}
