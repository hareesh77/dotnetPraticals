using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicCalculator;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        int num1=0;
        double floatnum1=0;
        int num2=0;
        double floatnum2=0;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "1";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text.Contains("."))
                floatnum1 = Convert.ToDouble(txt_Display.Text);
            else
                num1 = Convert.ToInt32(txt_Display.Text);

            operation = "Addition";
            txt_Display.Text = txt_Display.Text + " + ";
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            integerCalculation integerCalc = new integerCalculation();
            floatCalculations floatcalc = new floatCalculations();
            String expression = txt_Display.Text;
            if (operation == "Addition")
            {
                if ((expression.Split('+'))[1].Contains("."))
                    floatnum2 = Convert.ToDouble((expression.Split('+'))[1].ToString().Trim());
                else
                    num2 = Convert.ToInt32((expression.Split('+'))[1].ToString().Trim());

                if(num1!=0 && num2!=0)
                {
                    txt_Display.Text = integerCalc.addNumber(num1, num2).ToString();
                }
                else
                {
                 if(num1==0&& num2==0)
                    { 
                        txt_Display.Text = floatcalc.addNumber(floatnum1, floatnum2).ToString();
                    }
                 else
                    {
                        if (num1 == 0)
                        {
                            txt_Display.Text = floatcalc.addNumber(floatnum1, num2).ToString();
                        }
                        else
                        {
                            txt_Display.Text = floatcalc.addNumber(num1, floatnum2).ToString();

                        }
                    }
                }
            }

            num1 = 0;num2 = 0;floatnum1 = 0;floatnum2 = 0;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "4";
        }

        private void txt_5_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "5";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + ".";
        }
    }
}
