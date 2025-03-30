namespace Week04KimYoHan
{
    partial class FormManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxBirthYear = new System.Windows.Forms.TextBox();
            this.tbxAdvisor = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.tbxBirthMonth = new System.Windows.Forms.TextBox();
            this.lblBirthMonth = new System.Windows.Forms.Label();
            this.tbxBirthDay = new System.Windows.Forms.TextBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmxYear = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbRegStatus = new System.Windows.Forms.ComboBox();
            this.tbxContact = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lbxDictionary = new System.Windows.Forms.ListBox();
            this.lbxArray = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(116, 16);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 21);
            this.tbxNumber.TabIndex = 0;
            // 
            // tbxBirthYear
            // 
            this.tbxBirthYear.Location = new System.Drawing.Point(116, 66);
            this.tbxBirthYear.Name = "tbxBirthYear";
            this.tbxBirthYear.Size = new System.Drawing.Size(100, 21);
            this.tbxBirthYear.TabIndex = 0;
            // 
            // tbxAdvisor
            // 
            this.tbxAdvisor.Location = new System.Drawing.Point(116, 156);
            this.tbxAdvisor.Name = "tbxAdvisor";
            this.tbxAdvisor.Size = new System.Drawing.Size(381, 21);
            this.tbxAdvisor.TabIndex = 0;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(116, 299);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(381, 21);
            this.tbxAdress.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(15, 16);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 23);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "학번";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirth
            // 
            this.lblBirth.Location = new System.Drawing.Point(15, 63);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(100, 23);
            this.lblBirth.TabIndex = 1;
            this.lblBirth.Text = "생년월일";
            this.lblBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(15, 110);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(100, 23);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "소속학과";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.Location = new System.Drawing.Point(15, 157);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(100, 23);
            this.lblAdvisor.TabIndex = 1;
            this.lblAdvisor.Text = "지도교수";
            this.lblAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(15, 204);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(100, 23);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "학년";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.Location = new System.Drawing.Point(15, 251);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(100, 23);
            this.lblRegStatus.TabIndex = 1;
            this.lblRegStatus.Text = "재적상태";
            this.lblRegStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdress
            // 
            this.lblAdress.Location = new System.Drawing.Point(15, 298);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(100, 23);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "주소";
            this.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(15, 345);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(100, 23);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "연락처";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(300, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(397, 16);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 21);
            this.tbxName.TabIndex = 0;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.Location = new System.Drawing.Point(226, 65);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(44, 23);
            this.lblBirthYear.TabIndex = 1;
            this.lblBirthYear.Text = "년";
            this.lblBirthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthMonth
            // 
            this.tbxBirthMonth.Location = new System.Drawing.Point(280, 65);
            this.tbxBirthMonth.Name = "tbxBirthMonth";
            this.tbxBirthMonth.Size = new System.Drawing.Size(46, 21);
            this.tbxBirthMonth.TabIndex = 0;
            // 
            // lblBirthMonth
            // 
            this.lblBirthMonth.Location = new System.Drawing.Point(336, 66);
            this.lblBirthMonth.Name = "lblBirthMonth";
            this.lblBirthMonth.Size = new System.Drawing.Size(44, 23);
            this.lblBirthMonth.TabIndex = 1;
            this.lblBirthMonth.Text = "월";
            this.lblBirthMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthDay
            // 
            this.tbxBirthDay.Location = new System.Drawing.Point(390, 65);
            this.tbxBirthDay.Name = "tbxBirthDay";
            this.tbxBirthDay.Size = new System.Drawing.Size(53, 21);
            this.tbxBirthDay.TabIndex = 0;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.Location = new System.Drawing.Point(453, 66);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(44, 23);
            this.lblBirthDay.TabIndex = 1;
            this.lblBirthDay.Text = "일";
            this.lblBirthDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(282, 200);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(100, 23);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "분반";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(116, 110);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(381, 20);
            this.cmbDepartment.TabIndex = 2;
            // 
            // cmxYear
            // 
            this.cmxYear.FormattingEnabled = true;
            this.cmxYear.Location = new System.Drawing.Point(116, 201);
            this.cmxYear.Name = "cmxYear";
            this.cmxYear.Size = new System.Drawing.Size(145, 20);
            this.cmxYear.TabIndex = 2;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(352, 201);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(145, 20);
            this.cmbClass.TabIndex = 2;
            // 
            // cmbRegStatus
            // 
            this.cmbRegStatus.FormattingEnabled = true;
            this.cmbRegStatus.Location = new System.Drawing.Point(116, 249);
            this.cmbRegStatus.Name = "cmbRegStatus";
            this.cmbRegStatus.Size = new System.Drawing.Size(145, 20);
            this.cmbRegStatus.TabIndex = 2;
            // 
            // tbxContact
            // 
            this.tbxContact.Location = new System.Drawing.Point(116, 346);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(381, 21);
            this.tbxContact.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 391);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 64);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(119, 391);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(378, 64);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 12;
            this.lbxList.Location = new System.Drawing.Point(516, 173);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(209, 124);
            this.lbxList.TabIndex = 4;
            // 
            // lbxDictionary
            // 
            this.lbxDictionary.FormattingEnabled = true;
            this.lbxDictionary.ItemHeight = 12;
            this.lbxDictionary.Location = new System.Drawing.Point(516, 330);
            this.lbxDictionary.Name = "lbxDictionary";
            this.lbxDictionary.Size = new System.Drawing.Size(209, 124);
            this.lbxDictionary.TabIndex = 4;
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.ItemHeight = 12;
            this.lbxArray.Location = new System.Drawing.Point(516, 16);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(209, 124);
            this.lbxArray.TabIndex = 4;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 472);
            this.Controls.Add(this.lbxArray);
            this.Controls.Add(this.lbxDictionary);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbRegStatus);
            this.Controls.Add(this.cmxYear);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblRegStatus);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAdvisor);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblBirthDay);
            this.Controls.Add(this.lblBirthMonth);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbxContact);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.tbxAdvisor);
            this.Controls.Add(this.tbxBirthDay);
            this.Controls.Add(this.tbxBirthMonth);
            this.Controls.Add(this.tbxBirthYear);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxNumber);
            this.Name = "FormManager";
            this.Text = "학생관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxBirthYear;
        private System.Windows.Forms.TextBox tbxAdvisor;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.TextBox tbxBirthMonth;
        private System.Windows.Forms.Label lblBirthMonth;
        private System.Windows.Forms.TextBox tbxBirthDay;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmxYear;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbRegStatus;
        private System.Windows.Forms.TextBox tbxContact;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.ListBox lbxDictionary;
        private System.Windows.Forms.ListBox lbxArray;
    }
}

