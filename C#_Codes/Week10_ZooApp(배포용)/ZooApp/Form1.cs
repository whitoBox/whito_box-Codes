using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //참고 : {dog > {animal} }
            Dog d = new Dog("dog1", COLOR.BLACK, 1);
            Animal a = new Dog("dog2", COLOR.BLACK, 1);
            //Animal c = new Animal("animal3", COLOR.BLACK);  < 추상클래스는 단독 인스턴스 생성 불가능
            //Dog b = new Animal("animal4", COLOR.BLACK);

            d.Bark(3); // d > {dog}
            //a.Bark(3); // a > {animal} > {dog} 대충 안된단 뜻
            ((Dog)a).Bark(3);

            tbxResult.Text = $"{a.Level} {d.Level} \r\n";
            a.Eat(); d.Eat(); // overriing  animal,dog 둘다 값을 바꿔버리는거
            tbxResult.Text += $"{a.Level} {d.Level} \r\n";
            a.Play(); d.Play(); // hiding   animal,dog 따로따로 있는거
            tbxResult.Text += $"{a.Level} {d.Level} \r\n";
        }
    }
}
