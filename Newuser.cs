using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleTrackingSystem
{
    public partial class Newuser : Form
    {
        public Newuser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Newuser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog=VehicleDatabase;Integrated Security=true");
            // SqlCommand cmd = new SqlCommand("insert into UserTable values('dheeksha','6754567567','jana','666')", conn);
            SqlCommand cmd = new SqlCommand("insert into UserTable values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
            
                
                conn.Open();


            int x1 = cmd.ExecuteNonQuery();

            if(x1==1)
            {
                MessageBox.Show("New User data added successfully");
            }
            else
            {
                MessageBox.Show("data not added successfully");
            }conn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            Login logObj = new Login();
            logObj.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
