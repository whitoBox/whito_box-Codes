namespace LabraryBook
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddBook = new System.Windows.Forms.TabPage();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAddBook.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddBook);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 416);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAddBook
            // 
            this.tabAddBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAddBook.Controls.Add(this.btnAddBook);
            this.tabAddBook.Controls.Add(this.tbxISBN);
            this.tabAddBook.Controls.Add(this.tbxAuthor);
            this.tabAddBook.Controls.Add(this.tbxTitle);
            this.tabAddBook.Controls.Add(this.label3);
            this.tabAddBook.Controls.Add(this.label2);
            this.tabAddBook.Controls.Add(this.label1);
            this.tabAddBook.Location = new System.Drawing.Point(4, 22);
            this.tabAddBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabAddBook.Name = "tabAddBook";
            this.tabAddBook.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabAddBook.Size = new System.Drawing.Size(557, 390);
            this.tabAddBook.TabIndex = 0;
            this.tabAddBook.Text = "도서 추가";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(137, 147);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(117, 28);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "도서 추가";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(79, 101);
            this.tbxISBN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxISBN.Name = "txtISBN";
            this.tbxISBN.Size = new System.Drawing.Size(233, 21);
            this.tbxISBN.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(79, 64);
            this.tbxAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAuthor.Name = "txtAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(233, 21);
            this.tbxAuthor.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(79, 27);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTitle.Name = "txtTitle";
            this.tbxTitle.Size = new System.Drawing.Size(233, 21);
            this.tbxTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "저자:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목:";
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.MistyRose;
            this.tabSearch.Controls.Add(this.btnReturn);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.btnCheckout);
            this.tabSearch.Controls.Add(this.txtSearch);
            this.tabSearch.Controls.Add(this.label5);
            this.tabSearch.Controls.Add(this.lblDueDate);
            this.tabSearch.Controls.Add(this.lblRentDate);
            this.tabSearch.Controls.Add(this.label4);
            this.tabSearch.Controls.Add(this.label6);
            this.tabSearch.Controls.Add(this.lbxSearchResults);
            this.tabSearch.Controls.Add(this.lblStatus);
            this.tabSearch.Controls.Add(this.lblBookTitle);
            this.tabSearch.Controls.Add(this.label7);
            this.tabSearch.Controls.Add(this.label10);
            this.tabSearch.Controls.Add(this.label9);
            this.tabSearch.Controls.Add(this.lblBookISBN);
            this.tabSearch.Controls.Add(this.lblBookAuthor);
            this.tabSearch.Controls.Add(this.label8);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabSearch.Size = new System.Drawing.Size(557, 390);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "도서 검색";
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(150, 344);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 28);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "도서 반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(408, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 21);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Location = new System.Drawing.Point(25, 344);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(117, 28);
            this.btnCheckout.TabIndex = 10;
            this.btnCheckout.Text = "도서 대출";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 21);
            this.txtSearch.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "제목:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Location = new System.Drawing.Point(315, 319);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(120, 12);
            this.lblDueDate.TabIndex = 9;
            // 
            // lblRentDate
            // 
            this.lblRentDate.Location = new System.Drawing.Point(81, 319);
            this.lblRentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(120, 12);
            this.lblRentDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "제목/저자/ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "저자:";
            // 
            // lstSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.ItemHeight = 12;
            this.lbxSearchResults.Location = new System.Drawing.Point(23, 55);
            this.lbxSearchResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxSearchResults.Name = "lstSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(472, 100);
            this.lbxSearchResults.TabIndex = 0;
            this.lbxSearchResults.SelectedIndexChanged += new System.EventHandler(this.lbxSearchResults_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(81, 282);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 12);
            this.lblStatus.TabIndex = 8;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Location = new System.Drawing.Point(81, 171);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(120, 12);
            this.lblBookTitle.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "ISBN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 319);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "반납예정일:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 319);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "대출일:";
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.Location = new System.Drawing.Point(81, 245);
            this.lblBookISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(120, 12);
            this.lblBookISBN.TabIndex = 7;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.Location = new System.Drawing.Point(81, 208);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(120, 12);
            this.lblBookAuthor.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "상태:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 416);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "도서관 관리 시스템";
            this.tabControl1.ResumeLayout(false);
            this.tabAddBook.ResumeLayout(false);
            this.tabAddBook.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddBook;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label label10;
    }
}
