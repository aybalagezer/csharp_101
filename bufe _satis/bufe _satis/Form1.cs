﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bufe__satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet,toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            su = Convert.ToInt16(txtcay.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            cay = Convert.ToInt16(txtcay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lbltoplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtcay.Text = "";
            txtsu.Text = "";
            txtmisir.Text = "";
            txtmisir.Focus();
        }
    }
}
