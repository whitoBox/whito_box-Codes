namespace Week03Homework
{
    partial class Form1
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
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExpression
            // 
            this.lblExpression.Location = new System.Drawing.Point(11, 10);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(244, 34);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumbers
            // 
            this.lblNumbers.BackColor = System.Drawing.Color.White;
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(11, 45);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(244, 51);
            this.lblNumbers.TabIndex = 1;
            this.lblNumbers.Text = "0";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(14, 105);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(56, 45);
            this.btnNum7.TabIndex = 2;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(75, 105);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(56, 45);
            this.btnNum8.TabIndex = 2;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(136, 105);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(56, 45);
            this.btnNum9.TabIndex = 2;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(198, 105);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 45);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(14, 154);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(56, 45);
            this.btnNum4.TabIndex = 2;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(75, 154);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(56, 45);
            this.btnNum5.TabIndex = 2;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(136, 154);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(56, 45);
            this.btnNum6.TabIndex = 2;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(198, 154);
            this.btnMul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(56, 45);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(14, 204);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(56, 45);
            this.btnNum1.TabIndex = 2;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(75, 204);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(56, 45);
            this.btnNum2.TabIndex = 2;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(136, 204);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(56, 45);
            this.btnNum3.TabIndex = 2;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(198, 204);
            this.btnSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(56, 45);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(14, 254);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(56, 45);
            this.btnNum0.TabIndex = 2;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(75, 254);
            this.btnCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(115, 45);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 254);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 312);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblExpression);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "계산기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAdd;
    }
}

