using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManagement
{
    public partial class FormManageClients : Form
    {
        public FormManageClients()
        {
            InitializeComponent();
            ClientsDSet.InitAdapters();
            ClientsDSet.LoadClients();
        }

    }
}
