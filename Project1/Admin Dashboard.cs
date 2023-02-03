using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders_Record or1 = new Orders_Record();
            or1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login al = new Admin_Login();
            al.Show();
        }
    }
}
