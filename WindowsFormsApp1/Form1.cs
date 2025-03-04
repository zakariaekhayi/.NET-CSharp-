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
        double num1, num2;
        string operation;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox_resultat.Text);
            switch (operation)
            {
                case "+":
                    textBox_resultat.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox_resultat.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox_resultat.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                        textBox_resultat.Text = (num1 / num2).ToString();
                    else
                        textBox_resultat.Text = "Erreur!";
                    break;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "1";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_resultat.Clear();
            num1 = num2 = 0;
            operation = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox_resultat.Text);
            operation = "+";
            textBox_resultat.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox_resultat.Text);
            operation = "/";
            textBox_resultat.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox_resultat.Text);
            operation = "*";
            textBox_resultat.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox_resultat.Text);
            operation = "-";
            textBox_resultat.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "0";
        }
    }
}
