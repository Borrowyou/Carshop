using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car.CarShopDataSetTableAdapters;

namespace Car
{
    public partial class MainForm : Form
    {
        CarShopDataSet DSCars;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carShopDataSet.Models' table. You can move, or remove it, as needed.
           this.carsTableAdapter.Fill(this.carShopDataSet.Cars);
           this.modelsTableAdapter.Fill(this.carShopDataSet.Models);
            
            DSCars = new CarShopDataSet();
        }
        
        private void ComboBoxDB(ComboBox ACBox)
        {
            
        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }
    }
}
