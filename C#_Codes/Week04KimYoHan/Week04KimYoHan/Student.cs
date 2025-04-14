using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04KimYoHan
{
    class Student
    {
        public String Number;
        public String Name;
        public DateTime BirthInfo;
        public String DepartmentCode;
        public String AdvisorNumber;
        public int Year;
        public String Class;
        public String RegStatus;
        public String Adress;
        public String Contact;

        public override string ToString()
        {
            return $"[{this.Number}] {this.Name}"; //this 안넣어도 되는데 가독성으로 넣으면 좋음 ^^
        }
    }
}
