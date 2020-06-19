using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widding_Guide
{
    public partial class userForm : Form
    {
        private string name;
        public int id;
        public userForm()
        {
            InitializeComponent();
            userhome1.setid(id);
            userhome1.BringToFront();
        }
        public userForm(string mname, int mid)
        {
            InitializeComponent();
            name = mname;
            id = mid;
            label2.Text = name;

            userhome1.setid(id);
            userhome1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userhome1.setid(id);
            userhome1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            useradd1.setid(id);
            useradd1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userupdate1.setid(id);
            userupdate1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
                 
        }

        private void userhome1_Load(object sender, EventArgs e)
        {

        }

    }
}
