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
    public partial class delete : UserControl
    {

        SqlConnection cn = new SqlConnection("Data Source =DESKTOP-74I7G65\\SQLEXPRESS; Initial Catalog=Weddingguide;Integrated Security = True ");
        private string wedTable = "Wedding Planner";
        private string locationTable = "Location";
        private string foodTable = "Food Agency";
        public delete()
        {
            InitializeComponent();

            comboBox1.Items.Add(wedTable);
            comboBox1.Items.Add(locationTable);
            comboBox1.Items.Add(foodTable);
        }

        private void foodID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == wedTable)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from [wedding planner] where wed_planner_id = '" + del.Text + "'", cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted sucessfully ", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    cn.Close();
                }
            }
            else if (comboBox1.Text == foodTable)
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from Foodagency where foodagency_id = '" + del.Text + "'", cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted sucessfully ", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from Location where location_id = '" + del.Text + "'", cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted sucessfully ", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
