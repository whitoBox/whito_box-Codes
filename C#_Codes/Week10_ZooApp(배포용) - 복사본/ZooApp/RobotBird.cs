using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class RobotBird : Animal, IRobot
    {
        private int _batteryLevel;
        public int BatteryLevel 
        { 
            get { return _batteryLevel; }
            set
            {
                if (value > 1000) _batteryLevel = 1000;
                else _batteryLevel = value;
            }
        }
        RobotBird(String name, COLOR color, int level)
        : base(name, color)
        {
            _batteryLevel = level;
        }

        public override string ToString()
        {
            return $"ROBOTBIRD : {Name}";
        }
        
        public string Fly(int count)
        {
            String retValue ="";
            for (int i = 0; i < count; i++)
            {
                retValue += "푸드득~";
            }
            return retValue;
        }
        protected override bool AddLevel(int level)
        {
            if (_level + level <= 50)
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

        public void Charge()
        {
            BatteryLevel = 1000;
        }
    }
}
