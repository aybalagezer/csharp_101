using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degiskenler_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, meslek, cinsiyet;
            adsoyad = textBox1.Text;
            meslek = textBox2.Text;
            cinsiyet = textBox3.Text;
            listBox1.Items.Add("Ad Soyad:" + adsoyad + "  Meslek:" + meslek + "  Cinsiyet:" + "  Yaş:" + maskedTextBox1.Text);
        }
    }
}
