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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=ANANTHITHANUMOO;Initial Catalog=VehicleDatabase;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select count(*) from UserTable where UName='"+ textBox1.Text+ "' and Pwd='"+ textBox2.Text+ "' ", conn);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
         //  DataGridView.DataSource = ds.Tables[0];
                     
            
             int x=Convert.ToInt32(  ds.Tables[0].Rows[0][0].ToString());
            
            
            if (x >= 1)
            {
                MessageBox.Show("logged in sucessfully");
                Home hmObj = new Home();
                hmObj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Wrong User name or Password ");

            }
            
            conn.Close();




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Newuser userObj = new Newuser();
            userObj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           // this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
