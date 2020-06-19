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
    public partial class adminForm : Form
    {

        public adminForm()
        {
            InitializeComponent();
            home1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void home1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add1.BringToFront();
        }

        private void add1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            update1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete1.BringToFront();
        }




        

    }
}
