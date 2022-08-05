using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girilen_Sembolün_Aritmatiği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, topla, cıkart, bol, carp;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            string operatorler;
            operatorler = Convert.ToString(textBox3.Text);
            topla = sayi1 + sayi2;
            cıkart = sayi1 - sayi2;
            carp = sayi1 * sayi2;
            bol = sayi1 / sayi2;
            switch(operatorler)
            {
                case "+":  textBox4.Text= topla.ToString(); 
                    break;
                case "-": textBox4.Text= cıkart.ToString();
                    break;
                case "*": textBox4.Text= carp.ToString();
                    break;
                case "/":textBox4.Text= bol.ToString();
                    break;
                default: textBox4.Text = "Hatalı";
                    break;
            }
        }
    }
}
