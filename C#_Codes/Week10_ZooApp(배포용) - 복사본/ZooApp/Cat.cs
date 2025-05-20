using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Cat : Animal
    {
        //private string _name;
        //private int _level;
        //private COLOR _color;

        //public string Name { get { return _name; } }
        //public COLOR Color { get { return _color; } }
        //public int Level { get { return _level; } }

        public Cat(string name, COLOR color)
            : base(name, color) { }


        public override string ToString()
        {
            return $"Cat: {Name}";
        }

        public string Meow(int count)   
        {
            string retValue = "";
            for (int i = 0; i < count; i++)
            {
                retValue += "Meow~";
            }
            return retValue;
        }

        public override void Eat() { AddLevel(300); }
        public new void Play() { AddLevel(200); }
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
