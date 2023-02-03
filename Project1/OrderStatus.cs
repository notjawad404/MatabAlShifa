using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class OrderStatus : Form
    {
        private SqlConnection cn;
        public OrderStatus()
        {
            InitializeComponent();
        }

        private void OrderStatus_Load(object sender, EventArgs e)
        {
            String conStr1 = "Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
            cn = new SqlConnection(conStr1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long phone1 = long.Parse(textBox1.Text);
            int Oid1 = int.Parse(textBox2.Text);
            SqlCommand cmd1 = new SqlCommand("Select * from Order1 where ID = '" + Oid1 + "' AND PhoneNo = '"+phone1+"'", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard ud = new UserDashboard();
            ud.Show();
        }
    }
}
