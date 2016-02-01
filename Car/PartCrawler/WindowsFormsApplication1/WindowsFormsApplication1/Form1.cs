using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Work";
            ServiceReference1.CalculatorClient calc = new ServiceReference1.CalculatorClient();
            label1.Text = calc.Add(5, 6).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TestService.Form1().Show();
        }
    }
}
