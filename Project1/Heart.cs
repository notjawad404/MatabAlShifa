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
    public partial class Heart : Form
    {
        public Heart()
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details : \n خون کے بڑھے ہوے دباؤ یعنی ہائی بلڈ پریشر کو کم کرنے میں مفید ثابت ہوتی ہے۔ اعصاب شرکیہ کے افعال کو درست کرتی ہے۔");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ترکیب استعمال: آدھے گرام کے 11 کیپسول صبح و شام نہار منہ پانی کے ساتھ لیں۔");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details: \n خون میں موجود زائد چربی کو کم کرنے میں مدد دیتی ہے۔ نیز خون کی نالیوں کو چکناہٹ سے پاک کرتی ہے۔");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ترکیب استعمال: دو چاۓ کے چمچ صبح نہار منہ لیں۔");
        }
    }
}
