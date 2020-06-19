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

    public partial class wedDate : UserControl
    {
        private int id;
        SqlConnection cn = new SqlConnection("Data Source =DESKTOP-74I7G65\\SQLEXPRESS; Initial Catalog=Weddingguide;Integrated Security = True ");
        public wedDate()
        {
            InitializeComponent();

        }
        public void setid(int idd)
        {
            id = idd;
        }
        private void wedDate_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            plannerForm pf = new plannerForm();
            SqlCommand cmd = new SqlCommand("update [Wedding planner] set wed_planner_available_time= '" + updatee.Text + "' where wed_planner_id='" + id + "' ", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("date has been updated ");
            cn.Close();

        }
    }
}
