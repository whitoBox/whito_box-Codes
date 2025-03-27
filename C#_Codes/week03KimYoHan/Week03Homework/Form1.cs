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
        //2.연산자 눌린후 숫자를 누르면 또 새로 나와야한다.
        //'='누르면 또 새로 값 보여줘야함
        char currentOperand = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)//이름 바꾼후 ctrl + . or 왼쪽 전구 클릭
        {
            //sender가 호출한 요소다
            Button target = (Button)sender;
            if (lblNumbers.Text == "0")
            {
                lblNumbers.Text = target.Text;
            }
            else
                lblNumbers.Text += target.Text;
        }

        private void btnOperand_Click(object sender, EventArgs e)//이거 "연산" 영어로 바꾸기
        {
            if (int.Parse(lblNumbers.Text) < 1) return;
            Button target = (Button)sender;
            var opr1 = 0;
            opr1 = int.Parse(lblNumbers.Text);

            switch (target.Text)
            {
                case "+": {lblNumbers.Text += " + "; currentOperand = '+'; } break;
                case "-": {lblNumbers.Text += " - "; currentOperand = '-';} break;
                case "*": {lblNumbers.Text += " * "; currentOperand = '*';} break;
                case "/": {lblNumbers.Text += " / "; currentOperand = '/';} break;
            }                                        
            
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            string result;


        }
    }
}
