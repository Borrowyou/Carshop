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
        DMAppointments DMAppoitm;
        public TFormAppointments()
        {
            InitializeComponent();
            DMAppoitm = new DMAppointments();
            InitFormAppManage();

        }

        public void InitFormAppManage()
        {
            FormManageAppoitment = new TFormManageAppoitment();
            FormManageAppoitment.TopLevel = false;
            FormManageAppoitment.Dock = DockStyle.Fill;
            pnlFormHolder.Controls.Add(FormManageAppoitment);
            FormManageAppoitment.Show();
        }

    }
}
