using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widding_Guide
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source =DESKTOP-74I7G65\\SQLEXPRESS; Initial Catalog=Weddingguide;Integrated Security = True ");
            SqlCommand cmd;
            Form1 f = new Form1();
            try
            {

                cmd = new SqlCommand("insert into User(user_name,user_password,user_age) values('" + user_name.Text + "','" + user_pass.Text + "' , " + user_age.Text + ")", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (SqlException ex)                           
            {
                MessageBox.Show("Erorr : ", ex.Message);


            }

            MessageBox.Show("Account are created successfuly", "Message", 0, MessageBoxIcon.Information);
            this.Hide();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void user_name_Click_1(object sender, EventArgs e)
        {

            user_name.Clear();


            user_name.ForeColor = Color.FromArgb(78, 148, 206);
            panel1.BackColor = Color.FromArgb(78, 148, 206);

            user_pass.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            user_age.ForeColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
        }

        private void user_pass_Click_1(object sender, EventArgs e)
        {

            user_pass.Clear();

            user_pass.ForeColor = Color.FromArgb(78, 148, 206);
            panel2.BackColor = Color.FromArgb(78, 148, 206);
            user_pass.PasswordChar = '*';
            user_name.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;
            user_age.ForeColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
        }

        private void user_age_Click_1(object sender, EventArgs e)
        {

            user_age.Clear();

            user_age.ForeColor = Color.FromArgb(78, 148, 206);
            panel3.BackColor = Color.FromArgb(78, 148, 206);

            user_pass.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            user_name.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



    }
}
