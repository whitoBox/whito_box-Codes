using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Homework
{
    public partial class Form1 : Form
    {
        string currentOperand = "";
        string lblnumbersdata = "0";
        double opr1 = 0;
        int opr2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)// 0~9 숫자 버튼
        {
            //sender가 호출한 요소다
            Button target = (Button)sender;

            if (string.IsNullOrEmpty(lblExpression.Text) 
                || lblExpression.Text == "0")
            {
                lblExpression.Text = target.Text;
                lblnumbersdata = target.Text;
            }
            else if (lblExpression.Text == "0" && target.Text == "0") return;
            else
            {
                lblExpression.Text += target.Text;
                lblnumbersdata += target.Text;
            }
        }

        private void btnOperand_Click(object sender, EventArgs e)
        {
            if (lblnumbersdata == "0") return;
            if (lblnumbersdata[lblnumbersdata.Length - 1] == '+') return;
            if (lblnumbersdata[lblnumbersdata.Length - 1] == '-') return;
            if (lblnumbersdata[lblnumbersdata.Length - 1] == '*') return;
            if (lblnumbersdata[lblnumbersdata.Length - 1] == '/') return;

            Button target = (Button)sender;
            //opr1 = 0;
            //opr2 = 0;
            opr2 = int.Parse(lblnumbersdata);

            switch (target.Text)
            {
                case "+": { opr1 = opr1 + opr2; } break;
                case "-": { if (opr1 == 0)
                        {
                            opr1 = opr2;
                        }
                        else {
                            opr1 -= opr2;
                        }
                    }break;
                case "*": {
                        if (opr1 == 0)
                        {
                            opr1 = opr2;
                        }
                        else
                        {
                            opr1 *= opr2;
                        }
                    } break;
                case "/":
                    {
                        if (opr1 == 0)
                        {
                            opr1 = opr2;
                        }
                        else
                        {
                            opr1 /= opr2;
                        }
                    } break;
            }
            lblExpression.Text += " " + target.Text + " ";
            currentOperand = target.Text;
            lblnumbersdata = "0";
            
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblExpression.Text)) return;
            if(lblExpression.Text.Length > 2)
            {
                if (lblExpression.Text[lblExpression.Text.Length - 2] == '+') return;
                if (lblExpression.Text[lblExpression.Text.Length - 2] == '-') return;
                if (lblExpression.Text[lblExpression.Text.Length - 2] == '*') return;
                if (lblExpression.Text[lblExpression.Text.Length - 2] == '/') return;
            }


            opr2 = int.Parse(lblnumbersdata);
            switch (currentOperand)
            {
                case "+": { opr1 = opr1 + opr2; } break;
                case "-":
                    {
                        if (opr1 == 0)
                        {
                            opr1 = opr2;
                        }
                        else
                        {
                            opr1 -= opr2;
                        }
                    }
                    break;
                case "*":
                    {
                        if (opr1 == 0)
                        {
                            opr1 = opr2;
                        }
                        else
                        {
                            opr1 *= opr2;
                        }
                    }
                    break;
                case "/":
                    {
                        if (opr1 == 0)
                        {
                            opr1 = opr2;
                        }
                        else if (opr2 == 0)
                        {
                            MessageBox.Show("0으로 나눌수는 없어용");
                            lblExpression.Text = "";
                            return;
                        }
                        else
                        {
                            opr1 /= opr2;
                        }
                    }
                    break;
            }

            //lblExpression.Text += " = "+ opr1;
            lblExpression.Text = "";
            lblnumbersdata = "0";
            lblNumbers.Text = opr1.ToString();
            opr1 = 0;
            opr2 = 0;
            
        }
    }
}
