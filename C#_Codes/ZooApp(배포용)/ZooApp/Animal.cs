using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    abstract class Animal
    {
        private string _name;
        protected int _level;
        protected COLOR _color;

        public string Name { get { return _name; } }
        public COLOR Color { get { return _color; } }
        public int Level { get { return _level; } }

        public Animal(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        public override string ToString()
        {
            return $"Animal: {_name}";
        }

        //virtual = 하이딩/오버라이딩 모두 가능하게 만드는 키워드
        public virtual void Eat() { AddLevel(3); }
        public void Play() { AddLevel(2); }

        //추상 메도스, 헤더만있는
        abstract protected bool AddLevel(int level);
    }
}
