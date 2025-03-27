namespace Week03Proj01
{
    partial class FormWeek03
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
            this.tbxData1 = new System.Windows.Forms.TextBox();
            this.tbxData2 = new System.Windows.Forms.TextBox();
            this.tbxData3 = new System.Windows.Forms.TextBox();
            this.tbxData4 = new System.Windows.Forms.TextBox();
            this.tbxData5 = new System.Windows.Forms.TextBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.chkOption = new System.Windows.Forms.CheckBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.pnlRadioGroup = new System.Windows.Forms.Panel();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.rbtMul = new System.Windows.Forms.RadioButton();
            this.rbtSub = new System.Windows.Forms.RadioButton();
            this.rbtAdd = new System.Windows.Forms.RadioButton();
            this.btnProcess01 = new System.Windows.Forms.Button();
            this.btnProcess02 = new System.Windows.Forms.Button();
            this.btnProcess03 = new System.Windows.Forms.Button();
            this.btnProcess04 = new System.Windows.Forms.Button();
            this.btnProcess05 = new System.Windows.Forms.Button();
            this.btnProcess06 = new System.Windows.Forms.Button();
            this.btnProcess07 = new System.Windows.Forms.Button();
            this.btnProcess08 = new System.Windows.Forms.Button();
            this.btnProcess09 = new System.Windows.Forms.Button();
            this.btnProcess10 = new System.Windows.Forms.Button();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.chkIce = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxData1
            // 
            this.tbxData1.Location = new System.Drawing.Point(12, 12);
            this.tbxData1.Name = "tbxData1";
            this.tbxData1.Size = new System.Drawing.Size(100, 21);
            this.tbxData1.TabIndex = 0;
            // 
            // tbxData2
            // 
            this.tbxData2.Location = new System.Drawing.Point(118, 12);
            this.tbxData2.Name = "tbxData2";
            this.tbxData2.Size = new System.Drawing.Size(100, 21);
            this.tbxData2.TabIndex = 0;
            // 
            // tbxData3
            // 
            this.tbxData3.Location = new System.Drawing.Point(222, 12);
            this.tbxData3.Name = "tbxData3";
            this.tbxData3.Size = new System.Drawing.Size(100, 21);
            this.tbxData3.TabIndex = 0;
            // 
            // tbxData4
            // 
            this.tbxData4.Location = new System.Drawing.Point(328, 12);
            this.tbxData4.Name = "tbxData4";
            this.tbxData4.Size = new System.Drawing.Size(100, 21);
            this.tbxData4.TabIndex = 0;
            // 
            // tbxData5
            // 
            this.tbxData5.Location = new System.Drawing.Point(434, 12);
            this.tbxData5.Name = "tbxData5";
            this.tbxData5.Size = new System.Drawing.Size(100, 21);
            this.tbxData5.TabIndex = 0;
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(120, 48);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(48, 16);
            this.chkSub.TabIndex = 1;
            this.chkSub.Text = "빼기";
            this.chkSub.UseVisualStyleBackColor = true;
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(224, 48);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(60, 16);
            this.chkMul.TabIndex = 1;
            this.chkMul.Text = "곱하기";
            this.chkMul.UseVisualStyleBackColor = true;
            // 
            // chkDiv
            // 
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(330, 48);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(60, 16);
            this.chkDiv.TabIndex = 1;
            this.chkDiv.Text = "나누기";
            this.chkDiv.UseVisualStyleBackColor = true;
            // 
            // chkOption
            // 
            this.chkOption.AutoSize = true;
            this.chkOption.Location = new System.Drawing.Point(436, 48);
            this.chkOption.Name = "chkOption";
            this.chkOption.Size = new System.Drawing.Size(50, 16);
            this.chkOption.TabIndex = 1;
            this.chkOption.Text = "ENG";
            this.chkOption.UseVisualStyleBackColor = true;
            this.chkOption.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(14, 48);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(60, 16);
            this.chkAdd.TabIndex = 1;
            this.chkAdd.Text = "더하기";
            this.chkAdd.UseVisualStyleBackColor = true;
            // 
            // pnlRadioGroup
            // 
            this.pnlRadioGroup.Controls.Add(this.rbtDiv);
            this.pnlRadioGroup.Controls.Add(this.rbtMul);
            this.pnlRadioGroup.Controls.Add(this.rbtSub);
            this.pnlRadioGroup.Controls.Add(this.rbtAdd);
            this.pnlRadioGroup.Location = new System.Drawing.Point(12, 78);
            this.pnlRadioGroup.Name = "pnlRadioGroup";
            this.pnlRadioGroup.Size = new System.Drawing.Size(457, 45);
            this.pnlRadioGroup.TabIndex = 2;
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Location = new System.Drawing.Point(348, 14);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(59, 16);
            this.rbtDiv.TabIndex = 3;
            this.rbtDiv.TabStop = true;
            this.rbtDiv.Text = "나누기";
            this.rbtDiv.UseVisualStyleBackColor = true;
            // 
            // rbtMul
            // 
            this.rbtMul.AutoSize = true;
            this.rbtMul.Location = new System.Drawing.Point(226, 14);
            this.rbtMul.Name = "rbtMul";
            this.rbtMul.Size = new System.Drawing.Size(59, 16);
            this.rbtMul.TabIndex = 2;
            this.rbtMul.TabStop = true;
            this.rbtMul.Text = "곱하기";
            this.rbtMul.UseVisualStyleBackColor = true;
            // 
            // rbtSub
            // 
            this.rbtSub.AutoSize = true;
            this.rbtSub.Location = new System.Drawing.Point(112, 14);
            this.rbtSub.Name = "rbtSub";
            this.rbtSub.Size = new System.Drawing.Size(47, 16);
            this.rbtSub.TabIndex = 1;
            this.rbtSub.TabStop = true;
            this.rbtSub.Text = "빼기";
            this.rbtSub.UseVisualStyleBackColor = true;
            // 
            // rbtAdd
            // 
            this.rbtAdd.AutoSize = true;
            this.rbtAdd.Location = new System.Drawing.Point(17, 14);
            this.rbtAdd.Name = "rbtAdd";
            this.rbtAdd.Size = new System.Drawing.Size(59, 16);
            this.rbtAdd.TabIndex = 0;
            this.rbtAdd.TabStop = true;
            this.rbtAdd.Text = "더하기";
            this.rbtAdd.UseVisualStyleBackColor = true;
            // 
            // btnProcess01
            // 
            this.btnProcess01.Location = new System.Drawing.Point(13, 129);
            this.btnProcess01.Name = "btnProcess01";
            this.btnProcess01.Size = new System.Drawing.Size(84, 34);
            this.btnProcess01.TabIndex = 3;
            this.btnProcess01.Text = "연산1";
            this.btnProcess01.UseVisualStyleBackColor = true;
            this.btnProcess01.Click += new System.EventHandler(this.btnProcess01_Click);
            // 
            // btnProcess02
            // 
            this.btnProcess02.Location = new System.Drawing.Point(124, 129);
            this.btnProcess02.Name = "btnProcess02";
            this.btnProcess02.Size = new System.Drawing.Size(86, 34);
            this.btnProcess02.TabIndex = 3;
            this.btnProcess02.Text = "연산2";
            this.btnProcess02.UseVisualStyleBackColor = true;
            this.btnProcess02.Click += new System.EventHandler(this.btnProcess02_Click);
            // 
            // btnProcess03
            // 
            this.btnProcess03.Location = new System.Drawing.Point(247, 129);
            this.btnProcess03.Name = "btnProcess03";
            this.btnProcess03.Size = new System.Drawing.Size(83, 34);
            this.btnProcess03.TabIndex = 3;
            this.btnProcess03.Text = "연산3";
            this.btnProcess03.UseVisualStyleBackColor = true;
            this.btnProcess03.Click += new System.EventHandler(this.btnProcess03_Click);
            // 
            // btnProcess04
            // 
            this.btnProcess04.Location = new System.Drawing.Point(371, 129);
            this.btnProcess04.Name = "btnProcess04";
            this.btnProcess04.Size = new System.Drawing.Size(81, 34);
            this.btnProcess04.TabIndex = 3;
            this.btnProcess04.Text = "연산4";
            this.btnProcess04.UseVisualStyleBackColor = true;
            this.btnProcess04.Click += new System.EventHandler(this.btnProcess04_Click);
            // 
            // btnProcess05
            // 
            this.btnProcess05.Location = new System.Drawing.Point(491, 129);
            this.btnProcess05.Name = "btnProcess05";
            this.btnProcess05.Size = new System.Drawing.Size(86, 34);
            this.btnProcess05.TabIndex = 3;
            this.btnProcess05.Text = "button1";
            this.btnProcess05.UseVisualStyleBackColor = true;
            // 
            // btnProcess06
            // 
            this.btnProcess06.Location = new System.Drawing.Point(12, 169);
            this.btnProcess06.Name = "btnProcess06";
            this.btnProcess06.Size = new System.Drawing.Size(85, 34);
            this.btnProcess06.TabIndex = 3;
            this.btnProcess06.Text = "얼마 1";
            this.btnProcess06.UseVisualStyleBackColor = true;
            this.btnProcess06.Click += new System.EventHandler(this.btnProcess06_Click);
            // 
            // btnProcess07
            // 
            this.btnProcess07.Location = new System.Drawing.Point(124, 169);
            this.btnProcess07.Name = "btnProcess07";
            this.btnProcess07.Size = new System.Drawing.Size(86, 34);
            this.btnProcess07.TabIndex = 3;
            this.btnProcess07.Text = "얼마 2";
            this.btnProcess07.UseVisualStyleBackColor = true;
            this.btnProcess07.Click += new System.EventHandler(this.btnProcess07_Click);
            // 
            // btnProcess08
            // 
            this.btnProcess08.Location = new System.Drawing.Point(247, 169);
            this.btnProcess08.Name = "btnProcess08";
            this.btnProcess08.Size = new System.Drawing.Size(83, 34);
            this.btnProcess08.TabIndex = 3;
            this.btnProcess08.Text = "얼마 3";
            this.btnProcess08.UseVisualStyleBackColor = true;
            this.btnProcess08.Click += new System.EventHandler(this.btnProcess08_Click);
            // 
            // btnProcess09
            // 
            this.btnProcess09.Location = new System.Drawing.Point(371, 169);
            this.btnProcess09.Name = "btnProcess09";
            this.btnProcess09.Size = new System.Drawing.Size(81, 34);
            this.btnProcess09.TabIndex = 3;
            this.btnProcess09.Text = "button1";
            this.btnProcess09.UseVisualStyleBackColor = true;
            // 
            // btnProcess10
            // 
            this.btnProcess10.Location = new System.Drawing.Point(491, 169);
            this.btnProcess10.Name = "btnProcess10";
            this.btnProcess10.Size = new System.Drawing.Size(86, 34);
            this.btnProcess10.TabIndex = 3;
            this.btnProcess10.Text = "button1";
            this.btnProcess10.UseVisualStyleBackColor = true;
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "아메리카노",
            "카페라떼",
            "플랫화이트"});
            this.cmbBeverage.Location = new System.Drawing.Point(13, 209);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(205, 20);
            this.cmbBeverage.TabIndex = 4;
            // 
            // chkIce
            // 
            this.chkIce.AutoSize = true;
            this.chkIce.Location = new System.Drawing.Point(224, 211);
            this.chkIce.Name = "chkIce";
            this.chkIce.Size = new System.Drawing.Size(48, 16);
            this.chkIce.TabIndex = 1;
            this.chkIce.Text = "얼음";
            this.chkIce.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LightGray;
            this.lblResult.Location = new System.Drawing.Point(11, 244);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(576, 236);
            this.lblResult.TabIndex = 5;
            // 
            // FormWeek03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 489);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.btnProcess10);
            this.Controls.Add(this.btnProcess05);
            this.Controls.Add(this.btnProcess09);
            this.Controls.Add(this.btnProcess04);
            this.Controls.Add(this.btnProcess08);
            this.Controls.Add(this.btnProcess07);
            this.Controls.Add(this.btnProcess03);
            this.Controls.Add(this.btnProcess02);
            this.Controls.Add(this.btnProcess06);
            this.Controls.Add(this.btnProcess01);
            this.Controls.Add(this.pnlRadioGroup);
            this.Controls.Add(this.chkAdd);
            this.Controls.Add(this.chkOption);
            this.Controls.Add(this.chkDiv);
            this.Controls.Add(this.chkMul);
            this.Controls.Add(this.chkIce);
            this.Controls.Add(this.chkSub);
            this.Controls.Add(this.tbxData5);
            this.Controls.Add(this.tbxData4);
            this.Controls.Add(this.tbxData3);
            this.Controls.Add(this.tbxData2);
            this.Controls.Add(this.tbxData1);
            this.Name = "FormWeek03";
            this.Text = "Form1";
            this.pnlRadioGroup.ResumeLayout(false);
            this.pnlRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxData1;
        private System.Windows.Forms.TextBox tbxData2;
        private System.Windows.Forms.TextBox tbxData3;
        private System.Windows.Forms.TextBox tbxData4;
        private System.Windows.Forms.TextBox tbxData5;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkDiv;
        private System.Windows.Forms.CheckBox chkOption;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.Panel pnlRadioGroup;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.RadioButton rbtMul;
        private System.Windows.Forms.RadioButton rbtSub;
        private System.Windows.Forms.RadioButton rbtAdd;
        private System.Windows.Forms.Button btnProcess01;
        private System.Windows.Forms.Button btnProcess02;
        private System.Windows.Forms.Button btnProcess03;
        private System.Windows.Forms.Button btnProcess04;
        private System.Windows.Forms.Button btnProcess05;
        private System.Windows.Forms.Button btnProcess06;
        private System.Windows.Forms.Button btnProcess07;
        private System.Windows.Forms.Button btnProcess08;
        private System.Windows.Forms.Button btnProcess09;
        private System.Windows.Forms.Button btnProcess10;
        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.CheckBox chkIce;
        private System.Windows.Forms.Label lblResult;
    }
}

