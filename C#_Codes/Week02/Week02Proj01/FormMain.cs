using System;
using System.Windows.Forms;

namespace Week02Proj01
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOutput01_Click(object sender, EventArgs e)
        {
            bool isToggle = chkToggle.Checked;          //true or false

            if (isToggle) {
                string data1 = tbxInput1.Text;
                string data2 = tbxInput2.Text;
                string result = data1 + data2;          //문자열연결연산자
                lblResult.Text = result;
            } else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2;             //산술연산자
                lblResult.Text = result.ToString();
            }
        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if (chkToggle.Checked == false) {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //산술연산자
                lblResult.Text = "더하기:" + result.ToString();
            } else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 - data2; //산술연산자
                lblResult.Text = "빼기:" + result;        // 문자열+숫자=>문자열 연결 연산자로 동작
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
            int data1 = int.Parse(tbxInput1.Text);
            int data2 = int.Parse(tbxInput2.Text);

            if (chkToggle.Checked == false) {
                int result = data1 + data2; //산술연산자
                lblResult.Text = string.Format("더하기:{0}", result);
            } else {
                int result = data1 - data2; //산술연산자
                lblResult.Text = $"빼기: {result}";           //문자열보간법
            }
        }

        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxInput1.Text);
            double data2 = double.Parse(tbxInput2.Text);

            if (chkToggle.Checked == false) {
                double result = data1 + data2; //산술연산자
                lblResult.Text = string.Format("더하기:{0}", result);
            } else {
                double result = data1 - data2; //산술연산자
                lblResult.Text = $"빼기: {result}";//문자열보간법
            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxInput1.Text;
            lblResult.Text += Environment.NewLine; // "\r\n"
                                                   //lblResult.Text = Environment.NewLine;  //문자열임.
            lblResult.Text += tbxInput1.Text.GetType();
            //lblResult.Text = tbxInput1.Text.GetType();
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxInput1.Text[0];
            //lblResult.Text = tbxInput1.Text[0];             //char (문자)
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0].GetType();

            lblResult.Text += Environment.NewLine;
            char test1 = tbxInput1.Text[0];
            //c언어 : 1바이트 (ascii)
            //c# : 2바이트 (unicode)
            byte result1 = (byte)test1;   //1바이트 부호 미지원 정수형
            sbyte result4 = (sbyte)test1;   //1바이트 부호 지원 정수형
            short result2 = (short)test1; //2바이트 부호지원 정수형
            ushort result3 = test1;       //2바이트 부호 미지원 정수형
            //int, uint, long, ulong ...

            lblResult.Text += $"{test1},{result1},{result2},{result3}";

        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            //정수 -> 실수 :OK
            //실수 -> 정수 :처리 필요.
            //작은 숫자 -> 큰 숫자 : OK
            //큰 숫자 -> 작은 숫자 : 처리 필요
            int data1 = short.Parse(tbxInput1.Text);
            float data2 = (float)double.Parse(tbxInput2.Text);
            long data3 = long.Parse(tbxInput3.Text);
            int data4 = (int)data3;

            double result1 = data1 + data2 + data3 + data4;
            lblResult.Text = result1.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)1.9 + (int)1.6 => 2 
            long result2 = data1 + (long)data2 + data3 + data4;
            lblResult.Text += result2.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)(1.9 + 1.6) => 3 
            long result3 = (long)(data1 + data2 + data3 + data4);
            lblResult.Text += result3.ToString();
        }

        private void btnOutput08_Click(object sender, EventArgs e)
        {
            //관계연산자 이용
            bool result1 = (tbxInput1.Text == tbxInput2.Text);
            bool result2 = (tbxInput2.Text == tbxInput3.Text);
            bool result3 = (tbxInput1.Text == tbxInput3.Text);

            //논리연산자
            if (result1 && result2 && result3) {
                lblResult.Text = "모두 일치";
            } else if (result1 || result2 || result3) {
                lblResult.Text = "적어도 일치하는 데이터가 있음";
            } else {
                lblResult.Text = "모두 불일치";
            }
        }

        private void btnOutput07_Click(object sender, EventArgs e)
        {
            var data1 = int.Parse(tbxInput1.Text);
            var data2 = int.Parse(tbxInput2.Text);

            string result; //지역변수-초기화 자동으로 안됩니다.
            if (data1 == data2) {
                result = "같아요";
            } else if (data1 < data2) {
                result = "뒤가 커요";
            } else { //if (data1 > data2){
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
            lblResult.Text += decimal.MinValue.ToString() + "\n";
            lblResult.Text += decimal.MaxValue.ToString() + "\n";

        }

        private void btnOutput10_Click(object sender, EventArgs e)
        {
            //배열 array
            TextBox[] textBoxes;   //배열변수 선언
            textBoxes = new TextBox[5];//배열생성해서 변수에 위치 할당

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            //객체지향 언어의 특징
            //자료형은 class(or struct)로 만든다.
            //class: (값 + 추가 meta data) + 기능...
            int sum = 0;
            for(int i=0; i < textBoxes.Length; i++) {
                if (textBoxes[i].Text != null
                    && textBoxes[i].Text.Trim() != "") {
                    sum += int.Parse(textBoxes[i].Text);
                }
            }

            lblResult.Text = "총 합:" + sum;
        }

        private void btnOutput11_Click(object sender, EventArgs e)
        {
            //배열 array
            TextBox[] textBoxes;   //배열변수 선언
            textBoxes = new TextBox[5];//배열생성해서 변수에 위치 할당

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            int sum = 0;
            int count = 0;
            for (int i = 0; i < textBoxes.Length; i++) {
                if (textBoxes[i].Text != null
                    && textBoxes[i].Text.Trim() != "") {
                    sum += int.Parse(textBoxes[i].Text);
                    ++count;
                }
            }

            lblResult.Text = "평균:" + (sum / count);
        }
    }
}
