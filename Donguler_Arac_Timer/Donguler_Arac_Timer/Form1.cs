﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Arac_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac<=29)
            {
                this.BackColor = Color.Red;
            }
            if (sayac >= 30 && sayac<=40)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac >= 40 && sayac<=70)
            {
                this.BackColor = Color.Green;
            }
            if (sayac > 70)
            {
                sayac = 0;
            }
        }
    }
}
