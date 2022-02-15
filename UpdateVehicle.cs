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
    public partial class UpdateVehicle : Form
    {
        public UpdateVehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxVehNO.Text=="" || textBoxVehID.Text == "")
                {
                    MessageBox.Show("Please enter details to update");
                    return;
                }
                SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog = VehicleDatabase; Integrated Security = true");
                SqlCommand cmd = new SqlCommand("Update Vehicle set vehicle_name='"+ textBoxVehName.Text + "' where vehicle_no='"+ textBoxVehNO.Text + "' and id='"+ textBoxVehID.Text + "'", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int x = cmd.ExecuteNonQuery();
                if(x>=1)
                {
                    MessageBox.Show("Vehicle details Updated");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog = VehicleDatabase; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("select * from [Vehicle]", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void textBoxVehNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home hmObj2 = new Home();
            hmObj2.Show();
            this.Hide();
        }
    }
}
