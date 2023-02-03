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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Sign_in : Form
    {
        private SqlConnection cn;
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

            String conStr1= "Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
            cn =new SqlConnection(conStr1);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

           
            if (SPass1.Text == SCPass1.Text)
            {
                cn.Open();
                string uname = Susername1.Text;
                SqlCommand cmd1 = new SqlCommand("select UserName from signin where UserName='" + uname + "'", cn);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Username Already exist please try another ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    dr.Close();
                SqlCommand cmd = new SqlCommand("insert into signin values(@Name, @CNIC, @UserName, @Password1, @Address1)", cn);
                cmd.Parameters.AddWithValue("@Name", SName1.Text);
                cmd.Parameters.AddWithValue("@CNIC", long.Parse(SCnic1.Text));
                cmd.Parameters.AddWithValue("@UserName", Susername1.Text);
                cmd.Parameters.AddWithValue("@Password1", SPass1.Text);
                cmd.Parameters.AddWithValue("@Address1", Saddress1.Text);

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Account Created");
                    
                    this.Hide();
                    Login li = new Login();
                    li.Show();
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Pass should be same");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login li = new Login();
            li.Show();
        }
    }
}
