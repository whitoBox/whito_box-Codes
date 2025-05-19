using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Dog : Animal
    {
        //아래 두개는 부모 것을 접근 못해서 그대로 사용해도 상관 없음. (_name,_level)
        //private string _name;
        //private int _level;
        
        //_color는  부모 것에 접근 할 수 있지만 나만의 것을 만들 때 쓰는 경우
        //private new COLOR _color;

        //부모에도 없으니 따로 선언하는 것.
        private int _year;

        //나중에 한번 주석을 풀어서 이해를 해보세요.
        //public string Name { get { return _name; } }
        //public new COLOR Color { get { return _color; } }
        //public int Level { get { return _level; } }
        public int Year { get { return _year; } }

        public Dog(string name, COLOR color, int year)
            //:base() << 기본 base() 생성자
            :base(name, color)
        {
            //_name = name;
            //_color = color;
            _year = year;
        }

        public override string ToString()
        {
            return $"DOG: {Name}";
        }

        public string Bark(int count)
        {
            string retValue = "";
            for (int i = 0; i < count; i++)
            {
                retValue += "woof!";
            }
            return retValue;
        }

        //오버라이딩(재정의): 메소드
        //오버라이딩의 권한은 자식이 아니라 부모에게 가진다. 부모쪽에서 virtual이 붙어 있어야 자식에서 override를 할수 있다.
        public override void Eat() { AddLevel(30); }
        
        //하이딩(숨기기): 변수, 프로퍼티, 메소드
        //C#은 하이딩이 기본이다
        public new void Play() { AddLevel(20); }

        protected override bool AddLevel(int level)
        {
            if (_level + level <= 100)
            {
                _level += level;
                return true;
            }
            else
            {
                _level = 100;
                return false;
            }
        }
    }
}
