using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //열거형 enum == 정수에 이름을 붙이는 것.
    enum YEAR
    {
        ONE = 0,
        TWO = 1,
        THREE = 2,
        FOUR = 3,
            
        END= 4,
    }
    enum CLASS
    {
        A,
        B,
        C,

        END,
    }
    enum REG_STATUS
    {
        ENROLLED = 0,
        GRADUATED,
        ONLEAVE,
        EXPALLED,
        
        END,
    }
    class Student {
        //static field
        //메모리가 하나 할당 됨
        public static Dictionary<YEAR, string> YearNames = new Dictionary<YEAR, string>()
        {
            {YEAR.ONE,  "1학년"},
            {YEAR.TWO,  "2학년"},
            {YEAR.THREE,"3학년"},
            {YEAR.FOUR, "4학년 심화"},
        };
        public static Dictionary<REG_STATUS, string> RegStatusNames = new Dictionary<REG_STATUS, string>
        {
            {REG_STATUS.ENROLLED, "재학" },
            {REG_STATUS.GRADUATED, "졸업" },
            {REG_STATUS.ONLEAVE, "휴학" },
            {REG_STATUS.EXPALLED, "퇴학" },
        };

        public string Number { get; private set; } //학번
        public string Name { get; private set; } //이름
        public string getName()
        {
            return Name;
        }
        public DateTime BirthInfo { get; private set; } //생년월일
        public void SetBirthInfo(int year, int month, int day)
        {
            BirthInfo = new DateTime(year, month, day);
        }
        public string DepartmentCode { get; set; } //학과코드
        public string AdvisorNumber { get; set; } //지도교수번호
        public YEAR Year { get; set; } // 학년
        public CLASS Class { get; set; }// 반 
        public REG_STATUS RegStatus { get; set; }//재적상태

        //자동구현 프로퍼티
        //컴파일러가 private 변수 만들고 get, set을 구현함
        //string __addresss;
        public string Address { get; set; }//주소

        private string _contact;
        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }
        // 이 생성자로 인해서
        // 기본 생성자는 사용할 수 없게 되었으니 잘 생각해볼 것!
        public Student(string number, string name)
        {
            Number = number;
            Name = name;
        }
        public override string ToString()
        {
            return $"[{this.Number}]{this.Name}";
        }
    }
}
