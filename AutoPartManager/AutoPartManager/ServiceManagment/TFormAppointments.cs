using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceManagment
{
    public partial class TFormAppointments : Form
    {
        TFormManageAppoitment FormManageAppoitment;
        public TFormAppointments()
        {
            InitializeComponent();
            InitFormAppManage();
        }

        public void InitFormAppManage()
        {
            FormManageAppoitment = new TFormManageAppoitment();
            FormManageAppoitment.TopLevel = false;
            pnlFormHolder.Controls.Add(FormManageAppoitment);
            FormManageAppoitment.Show();
        }

    }
}
