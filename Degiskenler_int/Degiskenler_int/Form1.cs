using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar, cevre, alan;
            kenar = 4;
            cevre = kenar * 4;
            alan= kenar* kenar;
            label1.Text = "Alan: " + alan+ " Çevre: "+ cevre;
        }
    }
}
