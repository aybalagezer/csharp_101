using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris_İndirim_Tutar_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double ilk, son;
            adet = Convert.ToInt16(txtAdet.Text);
            ilk = adet * 8;
            txtİlk.Text = ilk + " TL";
            if(adet>=0 && adet<=20)
            {
                son = (adet*8)-(adet * 8 * 0.20);
                txtSon.Text = son + " TL";
            }
            else if( adet>=21 && adet<=40)
            {
                son = (adet * 8) - (adet * 8 * 0.40);
                txtSon.Text = son + " TL";
            }
            else (adet >= 41)
            {
                son = (adet * 8) - (adet * 8 * 0.50);
                txtSon.Text = son + " TL";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
            txtSon.Text = "";
            txtİlk.Text = "";
            txtAdet.Focus();
        }
    }
}
