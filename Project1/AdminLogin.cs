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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text.ToString();
            string pass = textBox2.Text.ToString();
            String conStr1 = "Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection cn = new SqlConnection(conStr1);
            cn.Open();
            if (uname != string.Empty && pass != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select * from AdminTable where AUname='" + uname + "' and APassword = '" + pass + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Admin_Dashboard ad = new Admin_Dashboard();
                    ad.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Account is not avilable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill all fields", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
