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

namespace Project1
{
    public partial class Medicines1 : Form
    {
        private SqlConnection cn;   
        public Medicines1()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            String conString1 = "Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
            cn = new SqlConnection(conString1);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Heart h = new Heart();
            h.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fever f = new Fever();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Joints j = new Joints();
            j.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard ud = new UserDashboard();
            ud.Show();
        }
    }
}
