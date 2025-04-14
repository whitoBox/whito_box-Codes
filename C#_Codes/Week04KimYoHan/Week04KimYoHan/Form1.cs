using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04KimYoHan
{
    public partial class FormManager : Form
    {
        //인스턴스 필드(변수), 멤버 변수
        Department[] departments;
        List<Professor> professors;
        Dictionary<String, Student> students; //딕셔너리 선언 <키자료형, value자료형>

        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣는다
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<String, Student>();
            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[]
            {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9
            };

            string[] a;
            cmbYear.Items.AddRange(new object[] {1,2,3,4}); //items는 모든 값을 받기 때문에 그거의 대등하는 object자료형으로 배열 맏느는 것을 추천
            a = new[] {"A","B","C"};
            cmbClass.Items.AddRange(a);
            a = new[] { "재학", "졸업", "휴학", "퇴학" };
            cmbRegStatus.Items.AddRange(a);
        }
        Student selectedStudent = null;
        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            //(구현)학과코드가 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다.
            if (string.IsNullOrEmpty(tbxDepartmentCode.Text))
            {
                MessageBox.Show("학과코드를 입력해주세요");
                tbxDepartmentCode.Focus();
                return;
            }
            //(구현)학과이름이 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다.
            if (string.IsNullOrEmpty(tbxDepartmentName.Text))
            {
                MessageBox.Show("학과이름를 입력해주세요");
                tbxDepartmentName.Focus();
                return;
            }
            int index = -1;
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] == null)
                {
                    if (index < 0)
                    {
                        index = i;
                    }
                    //break;
                }
                else
                {
                    if (departments[i].Code == tbxDepartmentCode.Text)
                    {
                        MessageBox.Show("동일한 코드는 사용할수 없습니다.");
                        tbxDepartmentCode.Focus();
                        return;
                    }
                }
            }
            if (index < 0)
            {
                MessageBox.Show("100개의 학과를 초과할수는 없습니다."); //메시지 띄우기.
                return;
            }
            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;
            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            //추후 아래 3문장은 지운다.
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)
            {
                //메시지 띄우고
                MessageBox.Show("삭제할 학과를 선택해주세요");
                return;
            }
            var target = (Department)lbxDepartment.SelectedItem;
            foreach(var student in students)
            {
                if(student.Value.DepartmentCode == target.Code)
                {
                    MessageBox.Show("해당 과에 소속되어 있는 학생이 있어 삭제할수 없습니다.");
                    return;
                }
            }

            //is 연산자, 타입 확인용으로 사용.
            if (lbxDepartment.SelectedItem is Department)
            {
                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }
                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
                lbxDepartment.SelectedIndex = -1;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear(); //초기화
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }
                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    clearStudentInfo();
                    cmbDepartment.Items.Clear(); //초기화
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbDepartment.Items.Add(department);
                        }
                    }
                    break;
                case 3:
                    ClearTestScoreInfo();
                    break;
                default:
                    break;
            }
        }

        private void ClearTestScoreInfo()
        {
            lblTestName.Text = String.Empty;
            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                tbxTestScores[i].Text = string.Empty;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfessorDepartment.SelectedIndex < 0)
                return;

            lbxProfessor.Items.Clear();

            //as  형변환 연산자.
            //형변환이 정상적이지 않으면 null 반환.
            var department = cmbProfessorDepartment.SelectedItem as Department;
            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor != null && professor.DepartmentCode == department.Code)
                    {        
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            //등록하면 바로 화면에 추가하도록 코딩한다.
            if(cmbProfessorDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("소속학과를 선택해 주세요");
                return;
            }
            //교수번호가 비어있음.
            if (string.IsNullOrEmpty(tbxProfessorNumber.Text))
            {
                MessageBox.Show("교수번호를 입력해주세요");
                tbxProfessorNumber.Focus();
                return;
            }
            //교수이름이 비어있음.
            if (string.IsNullOrEmpty(tbxProfessorName.Text))
            {
                MessageBox.Show("교수이름를 입력해주세요");
                tbxProfessorName.Focus();
                return;
            }
            //동일한 교수 번호가 있음
            for (int i = 0; i < professors.Count; i++)
            {
                if (professors[i].Number == tbxProfessorNumber.Text)
                {
                    MessageBox.Show("동일한 코드는 사용할수 없습니다.");
                    tbxDepartmentCode.Focus();
                    return;
                }
            }
            Professor prof = new Professor();
            prof.DepartmentCode = departments[cmbProfessorDepartment.SelectedIndex].Code;
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;
            professors.Add(prof);
            lbxProfessor.Items.Add(prof);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                //메시지 띄우고
                MessageBox.Show("삭제할 교수를 선택해주세요");
                return;
            }
            var target = (Professor)lbxProfessor.SelectedItem;
            foreach (var student in students)
            {
                if(student.Value.AdvisorNumber == target.Number)
                {
                    MessageBox.Show("해당 교수님이 담당하고 있는 학생이 있어 삭제할수 없습니다.");
                    return;
                }
            }


            //is 연산자, 타입 확인용으로 사용.
            if (lbxProfessor.SelectedItem is Professor)
            {
                for (int i = 0; i < professors.Count; i++)
                {
                    if (professors[i] == target)
                    {
                        professors.Remove(target);
                    }
                }
                lbxProfessor.Items.RemoveAt(lbxProfessor.SelectedIndex);
                lbxProfessor.SelectedIndex = -1;
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();
            var target = cmbDepartment.SelectedItem as Department;
            if (target != null)
            {
                foreach (var professor in professors)
                {
                    if (professor.DepartmentCode == target.Code)
                    {
                        cmbAdvisor.Items.Add(professor);
                    }
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clearStudentInfo();
        }
        private void clearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = null;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = null;
            tbxBirthDay.Text = null;
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAdress.Text = null;
            tbxContact.Text = null;
            tbxNumber.ReadOnly = false;
            selectedStudent = null;
            btnRegister.Text = "등록";
            lbxDictionary.SelectedIndex = -1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(selectedStudent == null)
            {
                var number = tbxNumber.Text.Trim();
                if (false == int.TryParse(number, out int _) || number.Length != 9)
                {
                    MessageBox.Show("학번이 유효하지 않습니다.");
                    tbxNumber.Focus();
                    return;
                }
                if (true == students.ContainsKey(number))
                {
                    MessageBox.Show("동일한 학번이 이미 있습니다.");
                    tbxNumber.Focus();
                    return;
                }
                RegisterStudent(number);
            }
            else
            {
                RegisterStudent(tbxNumber.Text);
                MessageBox.Show("수정됨");
            }
        }

        private void RegisterStudent(String number)
        {
            Student student = new Student();
            //학번
            student.Number = number;
            //이름
            if (true == string.IsNullOrEmpty(tbxName.Text) || tbxName.Text.Trim().Length < 2)
            {
                MessageBox.Show("이름이 유효하지 않습니다");
                tbxName.Focus();
                return;
            }
            student.Name = tbxName.Text.Trim();

            //생년월일
            if (int.TryParse(tbxBirthYear.Text, out var birthYear)) //유효한 년도인지 확인
            {
                if (birthYear > DateTime.Now.Year
                || birthYear < 1900)
                {
                    MessageBox.Show("년도가 유효하지 않습니다.");
                    tbxBirthYear.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("년도가 유효하지 않습니다.");
                return;
            }
            if (int.TryParse(tbxBirthMonth.Text, out var birthMonth)) // 유효한 달인지 확읹
            {
                if(birthMonth > 12 || birthMonth < 1)
                {
                    MessageBox.Show("달이 유효하지 않습니다.");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("달이 유효하지 않습니다.");
                tbxBirthMonth.Focus();
                return;
            }
            if (int.TryParse(tbxBirthDay.Text, out int birthDay)) // 유효한 날인지 확인
            {
                if(birthDay > DateTime.DaysInMonth(birthYear, birthMonth) || birthDay < 1)
                {
                    MessageBox.Show("날짜가 유효하지 않습니다");
                    tbxBirthDay.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("날짜가 유효하지 않습니다");
                tbxBirthDay.Focus();
                return;
            }
            //생년월일 입력
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }
            //지도교수
            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            }
            else
            {
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }
            //학년
            if (cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년을 선택해주세요");
                return;
            }
            else
            {
                student.Year = 1 + (int.Parse(cmbYear.SelectedIndex.ToString()));
            }
            //반
            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("반을 선택해주세요");
                return;
            }
            else
            {
                student.Class = cmbClass.SelectedItem.ToString();
            }
            //제적상태
            if(cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("제적상태를 선택해주세요");
                return;
            }
            else
            {
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }
            //주소
            student.Adress = tbxAdress.Text;
            //연락처
            student.Contact = tbxContact.Text;

            //students.Add(number, student); //딕셔너리에 데이터 추가방법2 (중복되면 에러남)
            students[number] = student; //딕셔너리에 데이터 추가방법1
            //lbxDictionary.Items.Add(student);
            lbxDictionary.Items.Clear();
            foreach(var item in students)
            {
                lbxDictionary.Items.Add(item.Value);
            }
            clearStudentInfo();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnNew_Click(this,EventArgs.Empty); <- 메소드 내가 임의로 호출하는 방법
            if (lbxDictionary.SelectedIndex < 0)
            {
                return;
            }
            var student = (lbxDictionary.SelectedItem as Student);

            clearStudentInfo();
            if (student != null)
            {
                DisplaySelectedStudent(student);
            }
        }

        private void DisplaySelectedStudent(Student Student)//학생정보 화면에 띄어주기
        {
            //학번,이름,생년월일 출력
            selectedStudent = Student;
            tbxNumber.ReadOnly = true; //학번은 함부로 바꾸지 못하도록 하는것
            tbxNumber.Text = Student.Number;
            tbxName.Text = Student.Name;
            tbxBirthYear.Text = Student.BirthInfo.Year.ToString();
            tbxBirthMonth.Text = Student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = Student.BirthInfo.Day.ToString();

            //학과 출력
            if (Student.DepartmentCode != null)
            {
                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i].Code == Student.DepartmentCode)
                    {
                        cmbDepartment.SelectedIndex = i;
                        break;
                    }
                }
            }
            //지도교수 출력
            for (int i = 0; i < cmbAdvisor.Items.Count; i++)
            {
                if (Student.AdvisorNumber == (cmbAdvisor.Items[i] as Professor).Number)
                {
                    cmbAdvisor.SelectedIndex = i;
                }
            }
            //학년 출력
            cmbYear.SelectedIndex = Student.Year - 1;
            //분반 출력
            for (int i = 0; i < cmbClass.Items.Count; i++)
            {
                if (Student.Class == cmbClass.Items[i].ToString())
                {
                    cmbClass.SelectedIndex = i;
                    break;
                }

            }
            //제적상태 출력
            for (int i = 0; i < cmbRegStatus.Items.Count; i++)
            {
                if (Student.RegStatus.ToString() == cmbRegStatus.Items[i].ToString())
                {
                    cmbRegStatus.SelectedIndex = i;
                    break;
                }
            }
            tbxAdress.Text = Student.Adress;
            tbxContact.Text = Student.Contact;
            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            ClearTestScoreInfo();
            selectedStudent = SerchStudentByNumber(tbxTestNumber.Text.Trim());
            if(selectedStudent == null)
            {
                MessageBox.Show("학번이 조회되지 않습니다.");
                tbxTestNumber.Focus();
            }
            else
            {
                lblTestName.Text = selectedStudent.Name;
            }
            

        }

        private Student SerchStudentByNumber(string Number)
        {
            if (students.ContainsKey(Number))
            {
                return students[Number];
            }
            else
            {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {

        }
    }
}
