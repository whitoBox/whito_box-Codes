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

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣는다
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];
            professors = new List<Professor>();
        }

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
            lbxDepartment.Items.Add(dept.Code);
            lbxDepartment.Items.Add(dept.Name);
            lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)
            {
                //메시지 띄우고
                MessageBox.Show("삭제할 학과를 선택해주세요");
                return;
            }

            //is 연산자, 타입 확인용으로 사용.
            if (lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;
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
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index값 검사해서 진행여부 결정+
            //(구현) 조회할 학과를 선택하라는 메세지를 띄우고 종료한다.
            
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
            prof.DepartmentCode = departments[cmbProfessorDepartment.SelectedIndex].Code;//선택된 학과 콤보 박승에서 갖고오기 (..집에 가고 시퍼)
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;
            professors.Add(prof);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                //메시지 띄우고
                MessageBox.Show("삭제할 교수를 선택해주세요");
                return;
            }

            //is 연산자, 타입 확인용으로 사용.
            if (lbxProfessor.SelectedItem is Professor)
            {
                var target = (Professor)lbxProfessor.SelectedItem;
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
    }
}
