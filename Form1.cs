using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2_1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            int n=int.Parse(Price.Text);
            int rub = n / 100;
            int kop = (n % 100);
            if (rub == 0)
            {
                MessageBox.Show($"{kop} коп.");
            }
            if (kop == 0)
            {
                MessageBox.Show($"{rub} руб.");
            }
            if (kop != 0 && rub != 0)
            {
                MessageBox.Show($"{rub} руб. {kop} коп.");
            }
        }
    }
}
