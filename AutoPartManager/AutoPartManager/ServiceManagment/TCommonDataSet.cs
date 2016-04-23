using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceManagment.TCommonDataSetTableAdapters;

namespace ServiceManagment {
    
    
    public partial class TCommonDataSet
    {
        ClientsTableAdapter ClientsAdapter;
        public ClientsTableAdapter ClinetsTblAdapter
        {
            get
            {
                if (ClientsAdapter == null)
                    ClientsAdapter = new ClientsTableAdapter();
                return ClientsAdapter;

            }
            set { ClientsAdapter = value; } 
        }

        public void LoadClientsList()
        {
            ClinetsTblAdapter.Fill(Clients);
        }
    }
}
