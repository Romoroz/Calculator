using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form

    {
        double a; //(1)  переменные (1,2) создана для математических операции

        double b; //(2)

        double s; //(3)  результат всех действии

        char d;   //(4)  переменная(4) для вывода результата

        double r; //(5)  переменная(5) для математических операции вывода sin, cos, tg, ctg, log, sqrt, sqr

        double m; //(6)  переменная(6) для превращение в отрицательных или положительных чисел

        double y; //(7)  переменная(7) для вывода цифр



        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "4";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "4";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "1";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "2";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "3";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "5";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "6";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "7";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "8";
            else if(textBox1.Text.Length >= 1)
                textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "9";
            else if (textBox1.Text.Length >= 1)
                textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text == s.ToString())
            {
                textBox1.Text = "0";
            }
            try {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            finally
            {
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = Double.Parse(textBox1.Text);
                textBox1.Text = "";
                d = '+';
                label1.Text = "+";
            }
            catch
            {
                textBox1.Text = "Ошибка";
                a = default(double);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            textBox1.ReadOnly = true;
            switch (d)
            {
                case '+':
                    {
                        b = Double.Parse(textBox1.Text);
                        s = a + b;
                        textBox1.Text = s.ToString() + Environment.NewLine;
                        break;
                    }
                case '-':
                    {
                        b = Double.Parse(textBox1.Text);
                        s = a - b;
                        textBox1.Text = s.ToString() + Environment.NewLine;
                        break;
                    }
                case '*':
                    {
                        b = Double.Parse(textBox1.Text);
                        s = a * b;
                        textBox1.Text = s.ToString() + Environment.NewLine;
                        break;
                    }
                case '/':
                    {
                        b = Double.Parse(textBox1.Text);
                        s = a / b;
                        textBox1.Text = s.ToString() + Environment.NewLine;
                        break;
                    }
            }
            a = default(double);
            b = default(double);
            s = default(double);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text.Length == 6)
            {
                if (textBox1.Text == "Ошибка")
                    textBox1.Text = "";
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            if (textBox1.Text == "")
                textBox1.Text += "0";
            else if (textBox1.Text.Length >= 2)
                textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            r = Convert.ToDouble(textBox1.Text);
            s = Math.Sqrt(a);
            textBox1.Text = s + Environment.NewLine;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            r = Convert.ToDouble(textBox1.Text);
            s = Math.Pow(a, 2);
            textBox1.Text = s + Environment.NewLine;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            a = default(double); // удаление переменной (1)
            textBox1.ReadOnly = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            r = Convert.ToDouble(textBox1.Text);
            s = Math.Tan(a);
            textBox1.Text = s + Environment.NewLine;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            r = Convert.ToDouble(textBox1.Text);
            s = 1 / Math.Tan(a);
            textBox1.Text = s + Environment.NewLine;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            r = Convert.ToDouble(textBox1.Text);
            s = Math.Cos(a);
            textBox1.Text = s + Environment.NewLine;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            r = Convert.ToDouble(textBox1.Text);
            s = Math.Sin(a);
            textBox1.Text = s + Environment.NewLine;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            r = Convert.ToDouble(textBox1.Text);
            s = Math.Log(a);
            textBox1.Text = s + Environment.NewLine;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                a = Double.Parse(textBox1.Text);
                textBox1.Text = "";
                d = '-';
                label1.Text = "-";
                textBox1.Text = "";
            }
            catch
            {
                textBox1.Text = "Ошибка";
                a = default(double);
            }
            finally 
            {
                s = a - b;    
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                a = Double.Parse(textBox1.Text);
                textBox1.Text = "";
                d = '*';
                label1.Text = "*";
            }
            catch
            {
                textBox1.Text = "Ошибка";
                a = default(double);
            }
            finally 
            {
                s = a * b;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                a = Double.Parse(textBox1.Text);
                textBox1.Text = "";
                d = '/';
                label1.Text = "/";
            }
            catch
            {
                textBox1.Text = "Ошибка";
                a = default(double);
            }
            finally
            {
                
            }
            
        }

      

        private void button26_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += ",";
        }



        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 97) // отработана кнопка '1 Numpad', можешь любую пишешь Keys. и будет виден выбор
            {
                button1.PerformClick();
            }
            if (e.KeyChar == 49) // отработана кнопка '1 Keyboard', можешь любую пишешь Keys. и будет виден выбор
            {
                button1.PerformClick();
            }
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 50)
            {
                button6.PerformClick();
            }
            if (e.KeyValue == 98)
            {
                button6.PerformClick();
            }
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 99)
            {
                button7.PerformClick();
            }
            if (e.KeyValue == 51)
            {
                button7.PerformClick();
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 100)
            {
                button2.PerformClick();
            }
            if (e.KeyValue == 52)
            {
                button2.PerformClick();
            }
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 101)
            {
                button4.PerformClick();
            }
            if (e.KeyValue == 53)
            {
                button4.PerformClick();
            }
                
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 102)
            {
                button8.PerformClick();
            }
            if (e.KeyValue == 54)
            {
                button8.PerformClick();
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 103)
            {
                button3.PerformClick();
            }
            if (e.KeyValue == 55)
            {
                button3.PerformClick();
            }
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 104)
            {
                button5.PerformClick();
            }
            if (e.KeyValue == 56)
            {
                button5.PerformClick();
            }
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 105)
            {
                button9.PerformClick();
            }
            if (e.KeyValue == 57)
            {
                button9.PerformClick();
            }
        }

        private void button19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 48)
            {
                button19.PerformClick();
            }
            if (e.KeyValue == 96)
            {
                button19.PerformClick();
            }
        }

        private void button26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 109)
            {
                button26.PerformClick();
            }
            if (e.KeyValue == 188)
            {
                button26.PerformClick();
            }
        }

        private void button16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 187)
            {
                button16.PerformClick();
            }
        }

        private void button10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8)
            {
                button10.PerformClick();
            }
        }

        private void button12_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 107)
            {
                button12.PerformClick();
            }
        }

        private void button13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 108)
            {
                button13.PerformClick();
            }
        }

        private void button14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 106)
            {
                button14.PerformClick();
            }
        }

        private void button15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 110)
            {
                button15.PerformClick();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            button1.KeyPress += new KeyPressEventHandler(button1_KeyPress);
            button2.KeyDown += new KeyEventHandler(button2_KeyDown);
            button3.KeyDown += new KeyEventHandler(button3_KeyDown);
            button4.KeyDown += new KeyEventHandler(button4_KeyDown);
            button5.KeyDown += new KeyEventHandler(button5_KeyDown);
            button6.KeyDown += new KeyEventHandler(button6_KeyDown);
            button7.KeyDown += new KeyEventHandler(button7_KeyDown);
            button8.KeyDown += new KeyEventHandler(button8_KeyDown);
            button9.KeyDown += new KeyEventHandler(button9_KeyDown);
            button12.KeyDown += new KeyEventHandler(button12_KeyDown);
            button13.KeyDown += new KeyEventHandler(button13_KeyDown);
            button14.KeyDown += new KeyEventHandler(button14_KeyDown);
            button15.KeyDown += new KeyEventHandler(button15_KeyDown);
            button16.KeyDown += new KeyEventHandler(button16_KeyDown);
            button19.KeyDown += new KeyEventHandler(button19_KeyDown);
            button26.KeyDown += new KeyEventHandler(button26_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                if (textBox1.Text.Length >= 1)
                {
                    m = Convert.ToDouble(textBox1.Text);
                    y = m * -1;
                    textBox1.Text = y.ToString() + Environment.NewLine;
                }
            y = default(double);
            m = default(double);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
