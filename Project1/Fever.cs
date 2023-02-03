using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Fever : Form
    {
        public Fever()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicines1 meds = new Medicines1();
            meds.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = int.Parse(textBox1.Text);
            int total1 = total * 6;
            label11.Text = total1.ToString();

            Cart c = new Cart();
            c.Value = label4.Text;
            c.Value1 = label11.Text;

            c.Show();
            this.Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total = int.Parse(textBox2.Text);
            int total1 = total * 6;
            label12.Text = total1.ToString();

            Cart c = new Cart();
            c.Value = label3.Text;
            c.Value1 = label12.Text;
            
            c.Show();
            this.Hide();

        }

        private void Fever_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details: \n کھانسی خشک و تر سینے کی جکڑن اور گلے کی خراش کے لیے بہترین دوا ہے۔", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ترکیب استعمال : صبح و شام 5 تا 10 گرام", "Usage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details: \n ہر قسم کے بخاروں خصوصاً ملیریا بخاروں کے لیے یے ضرر اور سستی دوا ہے۔", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ترکیب استعمال : ایک رتی سے چار رتی تک ہمراہ مناسب شربت یا عرق دن میں دوبار۔", "Usage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
