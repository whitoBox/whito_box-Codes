using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04KimYoHan
{
    class Professor
    {
        public String DepartmentCode;
        public String Number;
        public String Name;

        public override string ToString()
        {
            return $"[{this.Number}] {this.Name}";
        }

    }
}
