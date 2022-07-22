using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeuyg
{
    public partial class Form1 : Form
    {
        int cay = 0, kahve = 0, kola = 0;

        private void buttoncyeksi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label4.Text);
            sayi--;
            cay = sayi;
            label4.Text = cay.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string a= label8.Text;
            int b= Convert.ToInt32(label2.Text);
            int c= Convert.ToInt32(label4.Text);
            a = (b * c).ToString();
            label8.Text = a;

            string k = label12.Text;
            int d = Convert.ToInt32(label7.Text);
            int f = Convert.ToInt32(label11.Text);
            k = (d * f).ToString();
            label12.Text = k;

            string t = label15.Text;
            t = (a+k).ToString();
            label15.Text = t;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label11.Text);
            sayi++;
            kahve = sayi;
            label11.Text = kahve.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label11.Text);
            sayi--;
            kahve = sayi;
            label11.Text = kahve.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncyartı_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label4.Text);
            sayi++;
            cay = sayi;
            label4.Text = cay.ToString();
        }
    }
}
