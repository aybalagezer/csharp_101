using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Pasta_Pisirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10) 
            {
                label2.BackColor = Color.SandyBrown;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label2.BackColor = Color.SeaGreen;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value % 10 == 0)
            {
                label3.BackColor = Color.SandyBrown;
            }
            if (progressBar2.Value % 10 == 5)
            {
                label3.BackColor = Color.SeaGreen;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 1;
            if (progressBar3.Value % 2 == 0)
            {
                label4.BackColor = Color.SandyBrown;
            }
            if (progressBar3.Value % 2 == 1)
            {
                label4.BackColor = Color.SeaGreen;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("Afiyet Olsun");
            }
        }
    }
}
