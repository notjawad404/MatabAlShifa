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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login li = new Login();
            li.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicines1 med = new Medicines1();
            med.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderStatus os = new OrderStatus();
            os.Show();
        }
    }
}
