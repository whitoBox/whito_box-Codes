namespace PersonalExpenseTracker
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
            this.grpAddExpense = new System.Windows.Forms.GroupBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxExpenseDateDay = new System.Windows.Forms.TextBox();
            this.tbxExpenseDateMonth = new System.Windows.Forms.TextBox();
            this.tbxExpenseDateYear = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbxFilterCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.tbxFilterExpenseDateYear = new System.Windows.Forms.TextBox();
            this.tbxFilterExpenseDateMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grpAddExpense.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddExpense
            // 
            this.grpAddExpense.Controls.Add(this.btnAddExpense);
            this.grpAddExpense.Controls.Add(this.label6);
            this.grpAddExpense.Controls.Add(this.label10);
            this.grpAddExpense.Controls.Add(this.label9);
            this.grpAddExpense.Controls.Add(this.label4);
            this.grpAddExpense.Controls.Add(this.txtAmount);
            this.grpAddExpense.Controls.Add(this.label3);
            this.grpAddExpense.Controls.Add(this.cbxCategory);
            this.grpAddExpense.Controls.Add(this.label2);
            this.grpAddExpense.Controls.Add(this.tbxExpenseDateDay);
            this.grpAddExpense.Controls.Add(this.tbxExpenseDateMonth);
            this.grpAddExpense.Controls.Add(this.tbxExpenseDateYear);
            this.grpAddExpense.Controls.Add(this.tbxDescription);
            this.grpAddExpense.Controls.Add(this.label1);
            this.grpAddExpense.Location = new System.Drawing.Point(14, 11);
            this.grpAddExpense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpAddExpense.Name = "grpAddExpense";
            this.grpAddExpense.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpAddExpense.Size = new System.Drawing.Size(345, 248);
            this.grpAddExpense.TabIndex = 0;
            this.grpAddExpense.TabStop = false;
            this.grpAddExpense.Text = "지출 추가";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(218, 120);
            this.btnAddExpense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(106, 25);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "지출 추가";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(300, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "일";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(228, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "월";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(156, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "년";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "날짜:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(97, 66);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(233, 21);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "금액:";
            // 
            // cboCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(97, 41);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategory.Name = "cboCategory";
            this.cbxCategory.Size = new System.Drawing.Size(233, 20);
            this.cbxCategory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "카테고리:";
            // 
            // tbxExpenseDateDay
            // 
            this.tbxExpenseDateDay.Location = new System.Drawing.Point(252, 93);
            this.tbxExpenseDateDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxExpenseDateDay.Name = "tbxExpenseDateDay";
            this.tbxExpenseDateDay.Size = new System.Drawing.Size(44, 21);
            this.tbxExpenseDateDay.TabIndex = 5;
            this.tbxExpenseDateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxExpenseDateMonth
            // 
            this.tbxExpenseDateMonth.Location = new System.Drawing.Point(180, 93);
            this.tbxExpenseDateMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxExpenseDateMonth.Name = "tbxExpenseDateMonth";
            this.tbxExpenseDateMonth.Size = new System.Drawing.Size(44, 21);
            this.tbxExpenseDateMonth.TabIndex = 4;
            this.tbxExpenseDateMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxExpenseDateYear
            // 
            this.tbxExpenseDateYear.Location = new System.Drawing.Point(97, 93);
            this.tbxExpenseDateYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxExpenseDateYear.Name = "tbxExpenseDateYear";
            this.tbxExpenseDateYear.Size = new System.Drawing.Size(55, 21);
            this.tbxExpenseDateYear.TabIndex = 3;
            this.tbxExpenseDateYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(97, 18);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxDescription.Name = "txtDescription";
            this.tbxDescription.Size = new System.Drawing.Size(233, 21);
            this.tbxDescription.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "설명:";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lstExpenses);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.cbxFilterCategory);
            this.grpFilter.Controls.Add(this.label11);
            this.grpFilter.Controls.Add(this.label7);
            this.grpFilter.Controls.Add(this.lblTotalPrice);
            this.grpFilter.Controls.Add(this.label8);
            this.grpFilter.Controls.Add(this.tbxFilterExpenseDateMonth);
            this.grpFilter.Controls.Add(this.label12);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.tbxFilterExpenseDateYear);
            this.grpFilter.Location = new System.Drawing.Point(377, 12);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFilter.Size = new System.Drawing.Size(345, 247);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "필터";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(256, 51);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(74, 25);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "조회";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboFilterCategory
            // 
            this.cbxFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterCategory.FormattingEnabled = true;
            this.cbxFilterCategory.Location = new System.Drawing.Point(97, 24);
            this.cbxFilterCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxFilterCategory.Name = "cboFilterCategory";
            this.cbxFilterCategory.Size = new System.Drawing.Size(233, 20);
            this.cbxFilterCategory.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "카테고리:";
            // 
            // lstExpenses
            // 
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.ItemHeight = 12;
            this.lstExpenses.Location = new System.Drawing.Point(8, 92);
            this.lstExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.Size = new System.Drawing.Size(322, 112);
            this.lstExpenses.TabIndex = 4;
            // 
            // tbxFilterExpenseDateYear
            // 
            this.tbxFilterExpenseDateYear.Location = new System.Drawing.Point(97, 53);
            this.tbxFilterExpenseDateYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFilterExpenseDateYear.Name = "tbxFilterExpenseDateYear";
            this.tbxFilterExpenseDateYear.Size = new System.Drawing.Size(55, 21);
            this.tbxFilterExpenseDateYear.TabIndex = 1;
            this.tbxFilterExpenseDateYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxFilterExpenseDateMonth
            // 
            this.tbxFilterExpenseDateMonth.Location = new System.Drawing.Point(180, 53);
            this.tbxFilterExpenseDateMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFilterExpenseDateMonth.Name = "tbxFilterExpenseDateMonth";
            this.tbxFilterExpenseDateMonth.Size = new System.Drawing.Size(44, 21);
            this.tbxFilterExpenseDateMonth.TabIndex = 2;
            this.tbxFilterExpenseDateMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "날짜:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(156, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "년";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(228, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "월";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 217);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "금액 :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(68, 213);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(195, 21);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(747, 282);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpAddExpense);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "개인 지출 관리";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddExpense.ResumeLayout(false);
            this.grpAddExpense.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddExpense;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ListBox lstExpenses;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbxFilterCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxExpenseDateDay;
        private System.Windows.Forms.TextBox tbxExpenseDateMonth;
        private System.Windows.Forms.TextBox tbxExpenseDateYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxFilterExpenseDateMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFilterExpenseDateYear;
    }
}