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
    public partial class add : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-74I7G65\\SQLEXPRESS;Initial Catalog=Weddingguide;Integrated Security=True");

     
        public add()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into [wedding planner] (wed_planner_name,wedding_planner_pass,wed_planner_rate,cost_per_hour) values('" + wedname.Text + "','" + wedpass.Text + "','" + wedrate.Text + "','" + wedcost.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Foodagency(foodagency_name,fa_date,foodagency_rate,foodagency_cost) values('" + foodname.Text + "','" + fooddate.Text + "','" + foodrate.Text + "','" + foodcost.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Location (location_name , location_place , location_date ,location_rate , location_cost ) values ('" + locname.Text + "' , '" + locationplace.Text + "' , '" + locdate.Text + "' , '" + locrate.Text + "' , '" + loccost.Text + "' )  ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("added");
            con.Close();

        }

        
    }
}
