using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_bileti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden:" + comboBox1.Text);
            listBox1.Items.Add("Nereye: " + comboBox2.Text);
            listBox1.Items.Add("Tarih: " + dateTimePicker1.Text);
            listBox1.Items.Add("Ad Soyad:" + textBox1.Text);
            listBox1.Items.Add("TC: " + maskedTextBox1.Text);
            listBox1.Items.Add("Telefon Numarası: " + maskedTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
