using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01
{
    public partial class FormWeek03: Form
    {
        public FormWeek03()
        {
            InitializeComponent();
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            //배열의 가장 큰 특징 : 고.정.길.이
            //배열 생성 시 사용할 길이(Length)를 정해 놓고 시작
            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 함.
            //배열의 길이는 생성후 변하지 않기 때문에 다른 배열의 길이로 사용해도 괜찮음 :)

            //배열 요소의 초기값!
            //struct는 struct의 기본값 (ex: int > 0)
            //class는 null
            //int[] arrIntData = new int[5];
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i=0; i < arrTbxData.Length; i++)
            {
                if (arrTbxData[i].Text != null && arrTbxData[i].Text.Trim() != "")
                arrIntData[i] = int.Parse(arrTbxData[i].Text);
            }

            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] != 0) { 
                        result /= arrIntData[i];
                    }
                    else
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼요");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("연산을 선택하세요");
                return; //메소드를 즉시 종료하고 호출한 곳으로 돌아간다.
            }
            lblResult.Text = result.ToString();
        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            //배열의 가장 큰 특징 : 고.정.길.이
            //배열 생성 시 사용할 길이(Length)를 정해 놓고 시작
            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 함.
            //배열의 길이는 생성후 변하지 않기 때문에 다른 배열의 길이로 사용해도 괜찮음 :)

            //배열 요소의 초기값!
            //struct는 struct의 기본값 (ex: int > 0)
            //class는 null
            //int[] arrIntData = new int[5];
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
            }

            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] != 0)
                    {
                        result /= arrIntData[i];
                    }
                    else
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼요");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("연산을 선택하세요");
                return; //메소드를 즉시 종료하고 호출한 곳으로 돌아간다.
            }
            lblResult.Text = result.ToString();
        }
    }
}
