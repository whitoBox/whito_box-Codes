using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Student {
        public string Number; //학번
        public string Name; //이름
        public DateTime BirthInfo; //생년월일
        public string DepartmentCode; //학과코드
        public string AdvisorNumber; //지도교수번호
        public int Year; // 학년
        public string Class;// 반
        public string RegStatus;//재적상태
        public string Address;//주소
        public string Contact;//연락처
        public override string ToString() {
            return $"[{this.Number}]{this.Name}";
        }
    }
}
