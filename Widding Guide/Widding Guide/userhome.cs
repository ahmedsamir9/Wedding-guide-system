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
using System.Data; 

namespace Widding_Guide
{
    public partial class userhome : UserControl
    {
        private int idd;
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-74I7G65\\SQLEXPRESS;Initial Catalog=Weddingguide;Integrated Security=True");
       
        public userhome()
        {
            InitializeComponent();
        }
        public void setid(int id)
        {
            idd = id;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select wedding_info.wedding_id , wedding_info.wedding_date , [Wedding planner].wed_planner_name ,Location.location_name , Foodagency.foodagency_name  from wedding_info inner join Location on Location.location_id=wedding_info.location_id  inner join [Wedding planner] on [Wedding planner].wed_planner_id=wedding_info.wed_planner_idd inner join Foodagency  on wedding_info.foodagency_id=Foodagency.foodagency_id where wedding_info.user_idd='" + idd + "'", cn);
            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
           

          
        }
    }
}
