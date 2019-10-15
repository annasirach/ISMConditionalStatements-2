using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            double s = 0;
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            switch (textBox3.Text)
            {
                case "+":
                    {
                        s = a + b;
                        label1.Text = s.ToString("F2");
                        break;
                    }
                case "-":
                    {
                        s = a - b;
                        label1.Text = s.ToString("F2");
                        break;
                    }
                case "/":
                    {
                        s = a / b;
                        label1.Text = s.ToString("F2");
                        break;
                    }
                case "*":
                    {
                        s = a * b;
                        label1.Text = s.ToString("F2");
                        break;
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;

            n = int.Parse(textBox1.Text);
            if (n > 7 || n < 1)
            {
                MessageBox.Show("Ошибка при введении числа n!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n == 1) label1.Text = "Понедельник";
            if (n == 2) label1.Text = "Вторник";
            if (n == 3) label1.Text = "Среда";
            if (n == 4) label1.Text = "Четверг";
            if (n == 5) label1.Text = "Пятниця";
            if (n == 6) label1.Text = "Субота";
            if (n == 7) label1.Text = "Воскресенье";
        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int m;
            m = int.Parse(textBox1.Text);
            if ((m > 12) || (m < 1))
            {
                MessageBox.Show("Ошибка при введении числа m!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (m == 1) label1.Text = "Январь";
            if (m == 2) label1.Text = "Февраль";
            if (m == 3) label1.Text = "Март";
            if (m == 4) label1.Text = "Апрель";
            if (m == 5) label1.Text = "Май";
            if (m == 6) label1.Text = "Июнь";
            if (m == 7) label1.Text = "Июль";
            if (m == 8) label1.Text = "Август";
            if (m == 9) label1.Text = "Сентябрь";
            if (m == 10) label1.Text = "Октябрь";
            if (m == 11) label1.Text = "Ноябрь";
            if (m == 12) label1.Text = "Декабрь";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
