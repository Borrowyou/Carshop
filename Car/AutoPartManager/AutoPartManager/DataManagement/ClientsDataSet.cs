using System;
using System.Data;
using System.Data.SqlClient;
using DataManagement.ClientsDataSetTableAdapters;

namespace DataManagement {
    
    
    public partial class ClientsDataSet
    {
        public ClientsTableAdapter ClientTbAdapter { get; set; }
        public void InitAdapters()
        {
            ClientTbAdapter = new ClientsTableAdapter(); 
        }

        public void LoadClients()
        {
            ClientTbAdapter.Fill(Clients);      
        }

    }
}
