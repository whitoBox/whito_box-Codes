using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Professor
    {
        public string DepartmentCode { get; set; }
        public string Number { get; private set; }
        public string Name;

        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }
        public Professor(String number, string name,string departmentCode) {
            Number = number;
            Name = name;
            DepartmentCode = departmentCode;
        }
    }
}
