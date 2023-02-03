using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project1
{
    public partial class Orders_Record : Form
    {
        private SqlConnection cn;
        public Orders_Record()
        {
            
            InitializeComponent();
        }

        private void Orders_Record_Load(object sender, EventArgs e)
        {
            String conStr1 = "Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
            cn = new SqlConnection(conStr1);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Order1", cn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            MessageBox.Show("All orders are displayed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Oid1 = int.Parse(textBox1.Text);
            String status1 = textBox2.Text;

            cn.Open();
            SqlCommand cmd = new SqlCommand("update Order1 set Status = @Status where ID = @ID", cn);
            cmd.Parameters.AddWithValue("@Status", status1); 
            cmd.Parameters.AddWithValue("@ID",Oid1);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("Select * from Order1 where ID = '" + Oid1 + "'", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            MessageBox.Show("Order Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long phone1 = long.Parse(textBox3.Text);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Order1 where PhoneNo = '"+phone1+"'", cn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            
        }
    }
}
