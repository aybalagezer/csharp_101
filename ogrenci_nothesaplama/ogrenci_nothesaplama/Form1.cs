using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_nothesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, s3;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            s3 = Convert.ToInt16(textBox5.Text);
            ortalama = (s1 + s2 + s3) / 3;
            listBox1.Items.Add("AD: " + ad + "    SOYAD: " + soyad + "   ORTALAMA: " + ortalama);
        }
    }
}
