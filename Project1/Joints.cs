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
    public partial class Joints : Form
    {
        public Joints()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicines1 meds = new Medicines1();
            meds.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details: \n جوڑوں کے سوجن، سکیٹیکا اور جوڑوں کی سختی کو دور کرنے میں مدد دیتا ہے۔");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ترکیب استعمال: صبح و شام کھانا کھانے کے بعد ایک ایک گولی پانی کے ساتھ کھائیں۔");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details: \n اعصاب اور جوڑوں کی برودت کے لیئے پیغام حرارت");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ترکیب استعمال: ایک تا دو گولیاں روزانہ نیم گرم دودھ کے ساتھ لیں۔");
        }
    }
}
