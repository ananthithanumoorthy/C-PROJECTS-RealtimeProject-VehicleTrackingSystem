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
    public partial class Search_Vehicle : Form
    {
        public Search_Vehicle()
        {
            InitializeComponent();
        }

        private void textVehName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                if (textVehName.Text == "" || textVehNum.Text == "")
                {
                    MessageBox.Show("Please enter Vehicle details");
                    textVehName.Focus();
                    return;
                }

               

                SqlConnection conn = new SqlConnection("Data Source=ANANTHITHANUMOO;Initial Catalog=VehicleDatabase;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from vehicle where vehicle_name='"+ textVehName .Text+ "' and vehicle_no='"+ textVehNum.Text+ "'",conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home hmObj2 = new Home();
            hmObj2.Show();
            this.Hide();
        }
    }
    }

