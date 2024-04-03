using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double cur = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            cur = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cur = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double val;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "Введіть грошове значення.";
                return;
            }
            
            val = Convert.ToDouble(textBox1.Text);
            if (cur == 0)
            {
                Currency usd = new Dollar();
                val = usd.conv(val);
                label1.Text = Convert.ToString(val) + " гривень.";
            }
            if (cur == 1)
            {
                Currency eu = new Euro();
                val = eu.conv(val);
                label1.Text = Convert.ToString(val) + " гривень.";
            }  
            if (cur == 2)
            {
                label1.Text = "Оберіть початкову валюту.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    abstract class Currency
    {
        public abstract double conv(double amount);
    }

    class Dollar : Currency
    {
        public override double conv(double amount)
        {
            return amount * 39;
        }
    }

    class Euro : Currency
    {
        public override double conv(double amount)
        {
            return amount * 42;
        }
    }
}
