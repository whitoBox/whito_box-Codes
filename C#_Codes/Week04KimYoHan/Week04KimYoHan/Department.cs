﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04KimYoHan
{
    //Object 클래스를 상속한
    //Department 클래스를 
    class Department : Object 
    {
        public String Code;
        public String Name;

        public override string ToString()
        {
            return $"[{this.Code}] {this.Name}";
        }
    }
    
    
}
