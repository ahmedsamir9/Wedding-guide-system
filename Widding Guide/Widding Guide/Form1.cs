using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Widding_Guide
{
    public partial class Form1 : Form
    {
        private string admin = "Admin";
        private string WeddingP = "Wedding Planner";
        private string user = "User";
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(admin);
            comboBox1.Items.Add(user);
            comboBox1.Items.Add(WeddingP);
            comboBox1.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source =DESKTOP-74I7G65\\SQLEXPRESS; Initial Catalog=Weddingguide;Integrated Security = True ");
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            if (comboBox1.Text == admin)
            {
                da = new SqlDataAdapter("Select* from Admin where admin_name ='" + textBox1.Text + "'and admin_pass = '" + textBox2.Text + "'", cn);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    adminForm f = new adminForm();
                    this.Hide();
                    f.Show();
                }
                else
                    MessageBox.Show("Incorrect username and password ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == user)
            {

                da = new SqlDataAdapter("Select* from [User] where user_name ='" + textBox1.Text + "'and user_pass = '" + textBox2.Text + "'", cn);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    userForm f = new userForm(dt.Rows[0]["user_name"].ToString(), Convert.ToInt32(dt.Rows[0]["user_id"]));

                    this.Hide();
                    f.Show();
                }
                else
                    MessageBox.Show("Incorrect username and password ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == WeddingP)
            {

                da = new SqlDataAdapter("Select* from [wedding planner] where wed_planner_name ='" + textBox1.Text + "'and wedding_planner_pass = '" + textBox2.Text + "'", cn);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    plannerForm f = new plannerForm(dt.Rows[0]["wed_planner_name"].ToString(), Convert.ToInt32(dt.Rows[0]["wed_planner_id"]));

                    this.Hide();
                    f.Show();
                }
                else
                    MessageBox.Show("Incorrect username and password ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.FromArgb(78, 148, 206);
            panel1.BackColor = Color.FromArgb(78, 148, 206);

            textBox2.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            textBox2.ForeColor = Color.FromArgb(78, 148, 206);
            panel2.BackColor = Color.FromArgb(78, 148, 206);
            textBox2.PasswordChar = '*';

            textBox1.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;
        }


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == admin || comboBox1.Text == WeddingP)
            {
                MessageBox.Show("You are can't create acount ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }
    }
}
