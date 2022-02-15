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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hmObj2 = new Home();
            hmObj2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog=VehicleDatabase;Integrated Security=true");
           // SqlCommand cmd1 = new SqlCommand("insert into vehicle values('dheekshasumo','6754','tata','sumo')",conn);
           
            
            SqlCommand cmd1 = new SqlCommand("insert into vehicle values(' "+textBox1.Text+" ' , ' "+textBox2.Text+" ' , ' "+textBox3.Text+" ' , ' "+textBox4.Text +"')", conn);

            conn.Open();

            int x= cmd1.ExecuteNonQuery();

            if (x == 1)
            {
                MessageBox.Show("new vehicle  data added");
            }
            else
            {
                MessageBox.Show("vehicle data not added successfully");
            }
            conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home hmObj = new Home();
            hmObj.Show();
            this.Hide();
        }
    }
}
