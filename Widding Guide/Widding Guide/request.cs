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
    public partial class request : UserControl
    {
        private int id;
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-74I7G65\\SQLEXPRESS;Initial Catalog=Weddingguide;Integrated Security=True");
        public request()
        {
            InitializeComponent();
        }
        public void setid(int idd)
        {
            id = idd;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update wedding_info set wp_availablity = 'accepted' where wedding_id= '" + textBox1.Text + "' ", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void request_Load(object sender, EventArgs e)
        {


        }

        private void refreshh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select wedding_info.wedding_id  , [User].user_name , Location.location_name , Location.location_place, Foodagency.foodagency_name , wedding_info.wedding_date from wedding_info inner join [User] on wedding_info.user_idd= [User].user_id inner join Location on wedding_info.location_id=Location.location_id inner join Foodagency on wedding_info.foodagency_id=Foodagency.foodagency_id  where wedding_info.wed_planner_idd='" + id + "' ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
            
        }

        private void noo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update wedding_info set  wp_availablity = 'refused' where wedding_id='" + textBox1.Text + "' ", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
