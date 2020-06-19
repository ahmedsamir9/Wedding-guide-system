using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Widding_Guide
{
    public partial class home : UserControl
    {

        SqlConnection cn = new SqlConnection("Data Source =DESKTOP-74I7G65\\SQLEXPRESS; Initial Catalog=Weddingguide;Integrated Security = True ");
        private string wedTable = "Wedding Planner";
        private string locationTable = "Location";
        private string foodTable = "Food Agency";
        public home()
        {
            InitializeComponent();

            comboBox1.Items.Add(wedTable);
            comboBox1.Items.Add(locationTable);
            comboBox1.Items.Add(foodTable);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == wedTable)
            {
                cn.Open();
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("Select* from [wedding planner] ", cn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                cn.Close();
            }
            else if(comboBox1.Text == foodTable)
            {

                cn.Open();
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("Select* from Foodagency ", cn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                cn.Close();

            }
            else
            {


                cn.Open();
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("Select* From Location ", cn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                cn.Close();
            }
        }
    }
}
