using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Массивы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Mas = new int[15];
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Random rand = new Random();
                textBox1.Text = "";
                for (int i = 0; i < 15; i++)
                {
                    Mas[i] = rand.Next(-50, 50);
                    textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
                    + Convert.ToString(Mas[i]) + Environment.NewLine;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                    sum += Mas[i];
            }
            label2.Text = "Сумма элементов с четными индексами = " + sum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
