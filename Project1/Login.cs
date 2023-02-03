using System;
using System.Data;
using System.Data.SqlClient;




namespace Project1
{
    public partial class Login : Form
    {
        private SqlConnection cn;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String conStr1 = "Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
            cn = new SqlConnection(conStr1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = lUname1.Text.ToString();
            string pass = lPass1.Text.ToString();
            cn.Open();
            if (uname != string.Empty && pass != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select UserName, Password1 from signin where UserName='" + uname + "' and Password1 = '" + pass + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    dr.Close();
                    cn.Close();

                    this.Hide();

                    UserDashboard ud = new UserDashboard();
                    ud.Show();
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


            cn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in si = new Sign_in();
            si.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lAdmin1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login al = new Admin_Login();
            al.Show();
        }
    }
}