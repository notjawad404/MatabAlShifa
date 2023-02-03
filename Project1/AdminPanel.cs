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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Project1
{
    public partial class AdminPanel : Form
    {
        private SqlConnection cn;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)          //Show all users
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select ID, Name, CNIC, UserName, Address1 from signin", cn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            MessageBox.Show("All users are displayed");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            String conStr1 = "Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
            cn = new SqlConnection(conStr1);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login al = new Admin_Login();
            al.Show();
        }

        private void button2_Click(object sender, EventArgs e)          //show all orders
        {
            int Id1 = int.Parse(textBox1.Text);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select ID, Name, CNIC, UserName, Address1 from signin where ID = '"+Id1+"'", cn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            MessageBox.Show( "User Data is displayed ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
        }
    }
}
