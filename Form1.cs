using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3_simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enoperation { dev = 1, mul = 2, sub = 3, add = 4 };

        string number1=default;
        string number2 =default;
        char operation = default;
        string result = default;
        enoperation opr;
  

        void savevalueinnumber(Button btn)
        {
            if (operation == default)
            {
                number1 = number1 + btn.Tag;
                textBox1.Text = number1.ToString();
            }
            else
            {
                number2 += btn.Tag;
                textBox1.Text += number2.ToString();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }



        private void button13_Click(object sender, EventArgs e)
        {
            operation = '+';
            opr = enoperation.add;
            textBox1.Text +="+";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            switch (opr)
            {
                case enoperation.mul:


                    result = (Convert.ToInt32(number1) * Convert.ToInt32(number2)).ToString();
                    textBox1.Text = result;
                    number1 = result;
                    break;
                case enoperation.sub:


                    result = (Convert.ToInt32(number1) - Convert.ToInt32(number2)).ToString();
                    textBox1.Text = result;
                    number1 = result;
                    break;
                case enoperation.dev:


                    result = (Convert.ToInt32(number1) / Convert.ToInt32(number2)).ToString();

                    textBox1.Text = result;
                    number1 = result;
                    break;
                case enoperation.add:

                    result = (Convert.ToInt32(number1) + Convert.ToInt32(number2)).ToString();
                    textBox1.Text = result;
                    number1 = result;
                    break;

            }

            number2 = default;
            operation = default;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation = '/';
            opr = enoperation.dev;
            textBox1.Text += "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
        operation = '-';
            opr = enoperation.sub;
            textBox1.Text += "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation = '*';
            opr = enoperation.mul;
            textBox1.Text += "*";
        }




        private void btn_Click(object sender, EventArgs e)
        {
            savevalueinnumber((Button)sender);
        }


        private void btnAc_Click(object sender, EventArgs e)
        {
            number1 = default;
            number2 = default;
            operation = default;
            result = default;
            textBox1.Text = "";

        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (operation == default)
            {
                temp = Convert.ToInt32(number1);

                temp = temp / 10;

                number1 = temp.ToString();
                textBox1.Text = number1;
            }

            if (number2 == default)
            {
                operation = default;
                textBox1.Text = number1;
            }

            if (number2 != default)
            {
                temp = Convert.ToInt32(number2);

                temp = temp / 10;

                number2 = temp.ToString();
                textBox1.Text = number2;
                if (number2 == "0")
                {
                    number2 = default;
                    textBox1.Text = operation.ToString();
                }

            }



        }


        private void button15_Click(object sender, EventArgs e)
        {
     
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double temp = 0;
            temp = Convert.ToDouble(result);
            temp = (temp / 100);
            result = temp.ToString();
            textBox1.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
