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
    public partial class ViewVehicle : Form
    {
        public ViewVehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hmObj2 = new Home();
            hmObj2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog = VehicleDatabase; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("select * from [Vehicle]" , conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            }
        }
    }

