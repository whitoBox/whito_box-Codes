using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Proj01
{
    public partial class FromMain: Form
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void btnOutput01_Click(object sender, EventArgs e)
        {
            bool isToggle = chkToggle.Checked; // true or false
            if (isToggle) {
                string data1 = tbxInput1.Text;
                string data2 = tbxInput2.Text;
                string result = data1 + data2; //문자열 연결 연산자
                lblResult.Text = result;
            }
            else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //산술 연산자
                lblResult.Text = result.ToString();//모든 값을 문자열로 바꿀수 있임
            }
        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if (chkToggle.Checked == false)
            {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //산술 연산자
                lblResult.Text = "더하기:" + result.ToString();
            }
            else
            {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 - data2; //산술 연산자
                lblResult.Text = "빼기:" + result; //문자열+숫자 = 문자열
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
            int data1 = int.Parse(tbxInput1.Text);
            int data2 = int.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)
            {
                int result = data1 + data2; //산술 연산자
                lblResult.Text = string.Format("더하기:{0}", result);
            }
            else
            {
                int result = data1 - data2; //산술 연산자
                lblResult.Text = $"뺴기: {result}"; //문자열 보간법
            }
        }

        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxInput1.Text);
            double data2 = double.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)
            {
                double result = data1 + data2; //산술 연산자
                lblResult.Text = string.Format("더하기:{0}", result);
            }
            else
            {
                double result = data1 - data2; //산술 연산자
                lblResult.Text = $"뺴기: {result}"; //문자열 보간법
            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxInput1.Text;
            lblResult.Text += Environment.NewLine; // "\r\n" string 타입이다
            //lblResult.Text = Environment.NewLine; // 문자열
            lblResult.Text += tbxInput1.Text.GetType();
            //lblResult.Text = tbxInput1.Text.GetType(); Type 자료형 즉 대입이 안된다
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxInput1.Text[0]; //문자
            //lblResult.Text = tbxInput1.Text[0]; 문자 + 문자열 =/ 안된다.
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0].GetType();

            lblResult.Text += Environment.NewLine;
            char test1 = tbxInput1.Text[0];
            //c언어 char 1바이트 (ascii)
            //c# char 2바이트 (unicode)
            byte result1 = (byte)test1;   //1바이트 부호미지원 정수형
            sbyte result4 = (sbyte)test1; //1바이트 부호지원 정수형
            short result2 = (byte)test1;  //2바이트 부호지원 정수형
            ushort result3 = test1;       //2바이트 부호미지원 정수형
            //int, uint, long, ulong(8바이트) u = unsigned
            lblResult.Text +=
                $"{test1},{result1},{result2},{result3}";

        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {   
            //1) 정수 -> 실수: OK
            //2) 실수 -> 정수: 처리 필요
            //3) 작은 숫자 -> 큰 숫자 : OK
            //4) 큰 숫자 -> 작은 숫자 : 처리 필요
            int data1 = short.Parse(tbxInput1.Text); //3번
            float data2 = (float) double.Parse(tbxInput2.Text); //4번
            long data3 = long.Parse(tbxInput3.Text);
            int data4 = (int)data3; //4번

            double result1 = data1 + data2 + data3 + data4;
            lblResult.Text = result1.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)1.9 + (int)1.6 => 2
            long result2 = data1 + (long)data2 + data3 + data4;
            lblResult.Text += result2.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";
            //(int) (1.9 + 1.6) => 3
            long result3 = (long)(data1 + data2 + data3 + data4);
            lblResult.Text += result3.ToString();
        }

        private void btnOutput07_Click(object sender, EventArgs e)
        {
            bool result1 = (tbxInput1.Text == tbxInput2.Text);
            bool result2 = (tbxInput2.Text == tbxInput3.Text);
            bool result3 = (tbxInput1.Text == tbxInput3.Text);

            if(result1 && result2 && result3)
            {
                lblResult.Text = "모두일치";
            }else if(result1 || result2 || result3)
            {
                lblResult.Text = "적어도 일치하는 데이터가 있음";
            }
            else
            {
                lblResult.Text = "모두 불일치";
            }
        }
        private void btnOutput08_Click(object sender, EventArgs e)
        {
            var data1 = int.Parse(tbxInput1.Text);
            var data2 = int.Parse(tbxInput2.Text);

            string result;//지역변수는 초기화가 자동으로 되지 않습니다.
            if(data1 == data2)
            {
                result = "두 값이 같습니다";
            }else if (data1 < data2)
            {
                result = "뒤가 커요";
            }
            else //if(data1 > data2)
            {
                result = "앞이 커요"; 
            }

            lblResult.Text = result;
        }

        private void btnOutput09_Click(object sender, EventArgs e)
        {
            lblResult.Text = int.MinValue.ToString() + "\r\n";
            lblResult.Text += int.MaxValue.ToString() + "\r\n";
            lblResult.Text += Environment.NewLine;
            lblResult.Text += uint.MinValue.ToString() + "\r\n";
            lblResult.Text += uint.MaxValue.ToString() + "\r\n";
            lblResult.Text += Environment.NewLine;
            //고정소수점형
            lblResult.Text += decimal.MinValue.ToString() + "\r\n";
            lblResult.Text += decimal.MaxValue.ToString() + "\r\n";
        }

        private void btnOutput10_Click(object sender, EventArgs e)
        {
            //배열 array
            //TextBox Textboxes[5];
            TextBox[] textBoxes; //배열변수 선언 (textboxes는 배열이 아니라 배열을 제어해주는 배열변수)
            textBoxes= new TextBox[5];//배열 생성후 위치 할당(여기서 배열 만들어진거임)(레퍼런스 타임)

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            //객체지향 언어의 특징 중 하나는 
            //자료형을 class(or struct)로 만든다.
            //class = (값 + 추가 meta data) + 기능
            int sum = 0;
            for(int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "") {
                    sum += int.Parse(textBoxes[i].Text);
                }
            }
            lblResult.Text = "총 합:" + sum;
        }

        private void btnOutput11_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes; 
            textBoxes = new TextBox[5];

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            int sum = 0;
            int count = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "")
                {
                    sum += int.Parse(textBoxes[i].Text);
                    count++;
                }
            }
            lblResult.Text = "평균:" + sum / count;
        }
    }
}
