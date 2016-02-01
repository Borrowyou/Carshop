using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PartCrawler
{
    partial class PartService : ServiceBase
    {
        public PartService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            PartLinkCrawler PartLinkCrawl = new PartLinkCrawler();
            PartLinkCrawl.GetAllPartLinks();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
