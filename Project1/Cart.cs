using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Cart : Form
    {
        public Cart()
        {

            InitializeComponent();
        }

        public Cart(String value, String value1)
        {

            InitializeComponent();
            
            this.Value = value;
            this.Value1 = value1;
            
        }


        public String Value { get; set; }
        public String Value1 { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard ud = new UserDashboard();
            ud.Show();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            label4.Text = Value;
            label5.Text = Value1;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=GHOST\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True");
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into Order1 values(@Name ,@PhoneNo, @Mname, @Price, @AAddress, @Status)", con);
            cmd1.Parameters.AddWithValue("@Name", textBox3.Text);
            cmd1.Parameters.AddWithValue("@PhoneNo", long.Parse(textBox1.Text));
            cmd1.Parameters.AddWithValue("@Mname", label4.Text);
            cmd1.Parameters.AddWithValue("@Price", int.Parse(label5.Text));
            cmd1.Parameters.AddWithValue("@AAddress", textBox2.Text);
            cmd1.Parameters.AddWithValue("@Status", "Ordered");


            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order placed Successfully");
        }
    }
}
