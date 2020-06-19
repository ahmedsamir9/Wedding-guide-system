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
    public partial class userupdate : UserControl
    {
        private int id;
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-74I7G65\\SQLEXPRESS;Initial Catalog=Weddingguide;Integrated Security=True");
        SqlDataReader dr;
        
        public userupdate()
        {
            InitializeComponent();
        }
        public void setid(int i)
        {
            id = i;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select  Location.location_id , Foodagency.foodagency_id , [Wedding planner].wed_planner_id from wedding_info inner join Location on  wedding_info.location_id=  Location.location_id  inner join Foodagency on wedding_info.foodagency_id=Foodagency.foodagency_id inner join [Wedding planner] on wedding_info.wed_planner_idd=[Wedding planner].wed_planner_id  where wedding_info.user_idd ='" + id + "'", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            dr.Read();
            
            wp_id.Text = dr["wed_planner_idd"].ToString();
            loc_ID.Text = dr["location_id"].ToString();
            fd_id.Text = dr["foodagency_id"].ToString();
            SqlCommand cmd2 = new SqlCommand("update wedding_info set wed_planner_id ='" + wp_id.Text + "' , location_id= '" + loc_ID.Text + "' , foodagency_id='" + fd_id.Text + "'", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("data have been updated");
            cn.Close(); 
        }
    }
}
