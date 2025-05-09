namespace QuizCreationTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCreateQuestion = new System.Windows.Forms.GroupBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.rbtOption4 = new System.Windows.Forms.RadioButton();
            this.rbtOption3 = new System.Windows.Forms.RadioButton();
            this.rbtOption2 = new System.Windows.Forms.RadioButton();
            this.rbtOption1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxOption4 = new System.Windows.Forms.TextBox();
            this.tbxOption3 = new System.Windows.Forms.TextBox();
            this.tbxOption2 = new System.Windows.Forms.TextBox();
            this.tbxOption1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpQuestionList = new System.Windows.Forms.GroupBox();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.lbxQuestions = new System.Windows.Forms.ListBox();
            this.grpCreateQuestion.SuspendLayout();
            this.grpQuestionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreateQuestion
            // 
            this.grpCreateQuestion.Controls.Add(this.btnAddQuestion);
            this.grpCreateQuestion.Controls.Add(this.rbtOption4);
            this.grpCreateQuestion.Controls.Add(this.rbtOption3);
            this.grpCreateQuestion.Controls.Add(this.rbtOption2);
            this.grpCreateQuestion.Controls.Add(this.rbtOption1);
            this.grpCreateQuestion.Controls.Add(this.label6);
            this.grpCreateQuestion.Controls.Add(this.tbxOption4);
            this.grpCreateQuestion.Controls.Add(this.tbxOption3);
            this.grpCreateQuestion.Controls.Add(this.tbxOption2);
            this.grpCreateQuestion.Controls.Add(this.tbxOption1);
            this.grpCreateQuestion.Controls.Add(this.label5);
            this.grpCreateQuestion.Controls.Add(this.label4);
            this.grpCreateQuestion.Controls.Add(this.label3);
            this.grpCreateQuestion.Controls.Add(this.label2);
            this.grpCreateQuestion.Controls.Add(this.txtQuestionText);
            this.grpCreateQuestion.Controls.Add(this.label1);
            this.grpCreateQuestion.Location = new System.Drawing.Point(14, 11);
            this.grpCreateQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpCreateQuestion.Name = "grpCreateQuestion";
            this.grpCreateQuestion.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpCreateQuestion.Size = new System.Drawing.Size(436, 298);
            this.grpCreateQuestion.TabIndex = 0;
            this.grpCreateQuestion.TabStop = false;
            this.grpCreateQuestion.Text = "문제 생성";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(303, 255);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(107, 26);
            this.btnAddQuestion.TabIndex = 15;
            this.btnAddQuestion.Text = "문제 추가";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // radOption4
            // 
            this.rbtOption4.AutoSize = true;
            this.rbtOption4.Location = new System.Drawing.Point(397, 221);
            this.rbtOption4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtOption4.Name = "radOption4";
            this.rbtOption4.Size = new System.Drawing.Size(14, 13);
            this.rbtOption4.TabIndex = 14;
            this.rbtOption4.TabStop = true;
            this.rbtOption4.UseVisualStyleBackColor = true;
            // 
            // radOption3
            // 
            this.rbtOption3.AutoSize = true;
            this.rbtOption3.Location = new System.Drawing.Point(397, 191);
            this.rbtOption3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtOption3.Name = "radOption3";
            this.rbtOption3.Size = new System.Drawing.Size(14, 13);
            this.rbtOption3.TabIndex = 13;
            this.rbtOption3.TabStop = true;
            this.rbtOption3.UseVisualStyleBackColor = true;
            // 
            // radOption2
            // 
            this.rbtOption2.AutoSize = true;
            this.rbtOption2.Location = new System.Drawing.Point(397, 160);
            this.rbtOption2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtOption2.Name = "radOption2";
            this.rbtOption2.Size = new System.Drawing.Size(14, 13);
            this.rbtOption2.TabIndex = 12;
            this.rbtOption2.TabStop = true;
            this.rbtOption2.UseVisualStyleBackColor = true;
            // 
            // radOption1
            // 
            this.rbtOption1.AutoSize = true;
            this.rbtOption1.Location = new System.Drawing.Point(397, 130);
            this.rbtOption1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtOption1.Name = "radOption1";
            this.rbtOption1.Size = new System.Drawing.Size(14, 13);
            this.rbtOption1.TabIndex = 11;
            this.rbtOption1.TabStop = true;
            this.rbtOption1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "정답";
            // 
            // txtOption4
            // 
            this.tbxOption4.Location = new System.Drawing.Point(92, 219);
            this.tbxOption4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxOption4.Name = "txtOption4";
            this.tbxOption4.Size = new System.Drawing.Size(286, 21);
            this.tbxOption4.TabIndex = 9;
            // 
            // txtOption3
            // 
            this.tbxOption3.Location = new System.Drawing.Point(92, 189);
            this.tbxOption3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxOption3.Name = "txtOption3";
            this.tbxOption3.Size = new System.Drawing.Size(286, 21);
            this.tbxOption3.TabIndex = 8;
            // 
            // txtOption2
            // 
            this.tbxOption2.Location = new System.Drawing.Point(92, 158);
            this.tbxOption2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxOption2.Name = "txtOption2";
            this.tbxOption2.Size = new System.Drawing.Size(286, 21);
            this.tbxOption2.TabIndex = 7;
            // 
            // txtOption1
            // 
            this.tbxOption1.Location = new System.Drawing.Point(92, 128);
            this.tbxOption1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxOption1.Name = "txtOption1";
            this.tbxOption1.Size = new System.Drawing.Size(286, 21);
            this.tbxOption1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "옵션 4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "옵션 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "옵션 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "옵션 1:";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Location = new System.Drawing.Point(92, 28);
            this.txtQuestionText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(320, 51);
            this.txtQuestionText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "문제:";
            // 
            // grpQuestionList
            // 
            this.grpQuestionList.Controls.Add(this.btnDeleteQuestion);
            this.grpQuestionList.Controls.Add(this.lbxQuestions);
            this.grpQuestionList.Location = new System.Drawing.Point(458, 12);
            this.grpQuestionList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpQuestionList.Name = "grpQuestionList";
            this.grpQuestionList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpQuestionList.Size = new System.Drawing.Size(436, 297);
            this.grpQuestionList.TabIndex = 1;
            this.grpQuestionList.TabStop = false;
            this.grpQuestionList.Text = "문제 목록";
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(304, 254);
            this.btnDeleteQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(107, 26);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "문제 삭제";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // lstQuestions
            // 
            this.lbxQuestions.FormattingEnabled = true;
            this.lbxQuestions.ItemHeight = 12;
            this.lbxQuestions.Location = new System.Drawing.Point(27, 20);
            this.lbxQuestions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxQuestions.Name = "lstQuestions";
            this.lbxQuestions.Size = new System.Drawing.Size(384, 220);
            this.lbxQuestions.TabIndex = 0;
            this.lbxQuestions.SelectedIndexChanged += new System.EventHandler(this.lbxQuestions_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 328);
            this.Controls.Add(this.grpQuestionList);
            this.Controls.Add(this.grpCreateQuestion);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "퀴즈 제작 도구";
            this.grpCreateQuestion.ResumeLayout(false);
            this.grpCreateQuestion.PerformLayout();
            this.grpQuestionList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateQuestion;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.RadioButton rbtOption4;
        private System.Windows.Forms.RadioButton rbtOption3;
        private System.Windows.Forms.RadioButton rbtOption2;
        private System.Windows.Forms.RadioButton rbtOption1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxOption4;
        private System.Windows.Forms.TextBox tbxOption3;
        private System.Windows.Forms.TextBox tbxOption2;
        private System.Windows.Forms.TextBox tbxOption1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpQuestionList;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.ListBox lbxQuestions;
    }
}