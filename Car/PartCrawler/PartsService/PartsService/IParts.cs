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
    [ServiceContract]//(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IParts
    {
        [OperationContract]
        string UpdatePartByID(int iPartID);
    }
}
