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
            Price.Text = Properties.Settings.Default.n.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            int no = 0;
            bool proverka = int.TryParse(Price.Text, out no);
            if (proverka)
            {
                int n = int.Parse(Price.Text);
                int rub = n / 100;
                int kop = (n % 100);
                if (rub == 0)
                {
                    MessageBox.Show($"{kop} коп.");
                }
                else if (kop == 0)
                {
                    MessageBox.Show($"{rub} руб.");
                }
                else if (kop != 0 && rub != 0)
                {
                    MessageBox.Show($"{rub} руб. {kop} коп.");
                }
                Properties.Settings.Default.n = n;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Данные не введены, либо введены некорректно!");
            }
        }
    }
}
