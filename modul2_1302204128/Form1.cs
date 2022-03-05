using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204128
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string angka1 = string.Empty;
        string angka2 = string.Empty;
        char penjumlahan;
        int hasil;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button1.Text;
            this.textBox1.Text += input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button2.Text;
            this.textBox1.Text += input;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button3.Text;
            this.textBox1.Text += input;
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button4.Text;
            this.textBox1.Text += input;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button4.Text;
            this.textBox1.Text += input;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button5.Text;
            this.textBox1.Text += input;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button6.Text;
            this.textBox1.Text += input;
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button11.Text;
            this.textBox1.Text += input;
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button7.Text;
            this.textBox1.Text += input;
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            angka2 = input;
            int num1, num2;
            int.TryParse(angka1, out num1);
            int.TryParse(angka2, out num2);

            hasil = num1 + num2;
            textBox1.Text = hasil.ToString();
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            angka1 = input;
            penjumlahan = '+';
            input = string.Empty;
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += this.button8.Text + " ";
            this.textBox1.Text += input;
        }
    }
}
