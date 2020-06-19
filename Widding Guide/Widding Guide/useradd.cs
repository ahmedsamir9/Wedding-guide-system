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
    public partial class useradd : UserControl
    {
        private int idd;

        SqlConnection cn = new SqlConnection("Data Source =DESKTOP-74I7G65\\SQLEXPRESS; Initial Catalog=Weddingguide;Integrated Security = True ");
        private string wedTable = "Wedding Planner";
        private string locationTable = "Location";
        private string foodTable = "Food Agency";
        public useradd()
        {
            InitializeComponent();


            comboBox1.Items.Add(wedTable);
            comboBox1.Items.Add(locationTable);
            comboBox1.Items.Add(foodTable);
        }

        public void setid(int id)
        {
            idd=id;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == wedTable)
            {
                cn.Open();
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("Select* from [wedding planner]  where wed_planner_available_time = '" + user_date.Text + "'", cn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                cn.Close();
            }
            else if (comboBox1.Text == foodTable)
            {

                cn.Open();
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("Select* from Foodagency  where fa_date = '" + user_date.Text + "'", cn);
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
                da = new SqlDataAdapter("Select* From Location  where location_date = '" + user_date.Text + "'", cn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                cn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userForm us = new userForm();
            SqlCommand cmd = new SqlCommand("insert into wedding_info (wed_planner_idd,location_id,foodagency_id,wedding_date,user_idd) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + user_date.Text + "','" + idd + "') ", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("selections have been added to your wedding table");
            cn.Close();
        }

        private void user_date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
