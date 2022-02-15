using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VehicleTrackingSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewVehicle vehObj2 = new ViewVehicle();
            vehObj2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVehicle vehObj = new AddVehicle();
            vehObj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_Vehicle vehObj = new Search_Vehicle();
            vehObj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateVehicle vehObj = new UpdateVehicle();
            vehObj.Show();
            this.Hide();
        }
    }
}
