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
    public partial class update : UserControl
    {
        SqlConnection cn = new SqlConnection("Data Source =DESKTOP-74I7G65\\SQLEXPRESS; Initial Catalog=Weddingguide;Integrated Security = True ");
        SqlCommand cmd , cmd2;
        SqlDataReader dr;
        public update()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select foodagency_name , foodagency_rate , fa_date , foodagency_cost from foodagency where foodagency_id = '"+foodID.Text+"'" , cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                dr.Read();
                foodname.Text = dr["foodagency_name"].ToString();
                fooddate.Text = dr["fa_date"].ToString();
                foodrate.Text = dr["foodagency_rate"].ToString();
                foodcost.Text = dr["foodagency_cost"].ToString();
               
            }
            catch
            {

                MessageBox.Show(" data not found ", "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);

            }
            finally
            {
                dr.Close();
                cn.Close(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd2 = new SqlCommand("update Foodagency set foodagency_name='" + foodname.Text + "', fa_date='" + fooddate.Text + "', foodagency_rate = '" + foodrate.Text + "' ,foodagency_cost='" + foodcost.Text + "' where foodagency_id= '"+foodID.Text+"'", cn);
            cn.Open();
            cmd2.ExecuteNonQuery();
            cn.Close(); 
            MessageBox.Show("Updated Successfully");
        }
    }
}
