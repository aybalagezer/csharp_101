﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Aybala";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Aybala";
            label7.Text = "Gezer";
            label8.Text = "Mühendis";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "yazılım mühendisliği";
            label9.Text = textBox1.Text;
        }
    }
}
