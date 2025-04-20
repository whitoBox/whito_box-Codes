namespace Week07KimYoHan
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
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbxInputProductPrice = new System.Windows.Forms.TextBox();
            this.tbxInputProductStock = new System.Windows.Forms.TextBox();
            this.tbxInputProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSerchNameCode = new System.Windows.Forms.TextBox();
            this.gbxSerch = new System.Windows.Forms.GroupBox();
            this.lbxSerchProduct = new System.Windows.Forms.ListBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.tbxSerchProductCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSerchProductName = new System.Windows.Forms.Label();
            this.lblSerchProductCode = new System.Windows.Forms.Label();
            this.lblSerchProductPrice = new System.Windows.Forms.Label();
            this.lblSerchProductSalePrice = new System.Windows.Forms.Label();
            this.lblSerchProductStock = new System.Windows.Forms.Label();
            this.lblSerchProductRegDate = new System.Windows.Forms.Label();
            this.lblSerchProductTotalPrice = new System.Windows.Forms.Label();
            this.gbxInput.SuspendLayout();
            this.gbxSerch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnInput);
            this.gbxInput.Controls.Add(this.tbxInputProductPrice);
            this.gbxInput.Controls.Add(this.tbxInputProductStock);
            this.gbxInput.Controls.Add(this.tbxInputProductName);
            this.gbxInput.Controls.Add(this.label3);
            this.gbxInput.Controls.Add(this.label2);
            this.gbxInput.Controls.Add(this.label1);
            this.gbxInput.Location = new System.Drawing.Point(12, 12);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(283, 263);
            this.gbxInput.TabIndex = 0;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "상품등록";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(93, 146);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(125, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "등록";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbxInputProductPrice
            // 
            this.tbxInputProductPrice.Location = new System.Drawing.Point(93, 63);
            this.tbxInputProductPrice.Name = "tbxInputProductPrice";
            this.tbxInputProductPrice.Size = new System.Drawing.Size(125, 21);
            this.tbxInputProductPrice.TabIndex = 1;
            // 
            // tbxInputProductStock
            // 
            this.tbxInputProductStock.Location = new System.Drawing.Point(93, 103);
            this.tbxInputProductStock.Name = "tbxInputProductStock";
            this.tbxInputProductStock.Size = new System.Drawing.Size(125, 21);
            this.tbxInputProductStock.TabIndex = 1;
            // 
            // tbxInputProductName
            // 
            this.tbxInputProductName.Location = new System.Drawing.Point(93, 20);
            this.tbxInputProductName.Name = "tbxInputProductName";
            this.tbxInputProductName.Size = new System.Drawing.Size(125, 21);
            this.tbxInputProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "재고";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "가격";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // tbxSerchNameCode
            // 
            this.tbxSerchNameCode.Location = new System.Drawing.Point(20, 66);
            this.tbxSerchNameCode.Name = "tbxSerchNameCode";
            this.tbxSerchNameCode.Size = new System.Drawing.Size(137, 21);
            this.tbxSerchNameCode.TabIndex = 1;
            // 
            // gbxSerch
            // 
            this.gbxSerch.Controls.Add(this.lblSerchProductTotalPrice);
            this.gbxSerch.Controls.Add(this.lblSerchProductRegDate);
            this.gbxSerch.Controls.Add(this.lblSerchProductStock);
            this.gbxSerch.Controls.Add(this.lblSerchProductSalePrice);
            this.gbxSerch.Controls.Add(this.lblSerchProductPrice);
            this.gbxSerch.Controls.Add(this.lblSerchProductCode);
            this.gbxSerch.Controls.Add(this.lblSerchProductName);
            this.gbxSerch.Controls.Add(this.tbxSerchNameCode);
            this.gbxSerch.Controls.Add(this.lbxSerchProduct);
            this.gbxSerch.Controls.Add(this.btnCal);
            this.gbxSerch.Controls.Add(this.btnSerch);
            this.gbxSerch.Controls.Add(this.tbxSerchProductCount);
            this.gbxSerch.Controls.Add(this.label7);
            this.gbxSerch.Controls.Add(this.label6);
            this.gbxSerch.Controls.Add(this.label12);
            this.gbxSerch.Controls.Add(this.label11);
            this.gbxSerch.Controls.Add(this.label10);
            this.gbxSerch.Controls.Add(this.label9);
            this.gbxSerch.Controls.Add(this.label8);
            this.gbxSerch.Controls.Add(this.label5);
            this.gbxSerch.Controls.Add(this.label4);
            this.gbxSerch.Location = new System.Drawing.Point(301, 12);
            this.gbxSerch.Name = "gbxSerch";
            this.gbxSerch.Size = new System.Drawing.Size(487, 426);
            this.gbxSerch.TabIndex = 0;
            this.gbxSerch.TabStop = false;
            this.gbxSerch.Text = "상품조회";
            // 
            // lbxSerchProduct
            // 
            this.lbxSerchProduct.FormattingEnabled = true;
            this.lbxSerchProduct.ItemHeight = 12;
            this.lbxSerchProduct.Location = new System.Drawing.Point(20, 148);
            this.lbxSerchProduct.Name = "lbxSerchProduct";
            this.lbxSerchProduct.Size = new System.Drawing.Size(184, 244);
            this.lbxSerchProduct.TabIndex = 3;
            this.lbxSerchProduct.SelectedIndexChanged += new System.EventHandler(this.lbxSerchProduct_SelectedIndexChanged);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(404, 300);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(20, 103);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(137, 23);
            this.btnSerch.TabIndex = 2;
            this.btnSerch.Text = "조회";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // tbxSerchProductCount
            // 
            this.tbxSerchProductCount.Location = new System.Drawing.Point(307, 300);
            this.tbxSerchProductCount.Name = "tbxSerchProductCount";
            this.tbxSerchProductCount.Size = new System.Drawing.Size(66, 21);
            this.tbxSerchProductCount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "이름";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "총가격";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "수량";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "등록일자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "재고";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "할인가격";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "이름 && 코드";
            // 
            // lblSerchProductName
            // 
            this.lblSerchProductName.BackColor = System.Drawing.Color.White;
            this.lblSerchProductName.Location = new System.Drawing.Point(306, 31);
            this.lblSerchProductName.Name = "lblSerchProductName";
            this.lblSerchProductName.Size = new System.Drawing.Size(100, 23);
            this.lblSerchProductName.TabIndex = 4;
            // 
            // lblSerchProductCode
            // 
            this.lblSerchProductCode.BackColor = System.Drawing.Color.White;
            this.lblSerchProductCode.Location = new System.Drawing.Point(305, 72);
            this.lblSerchProductCode.Name = "lblSerchProductCode";
            this.lblSerchProductCode.Size = new System.Drawing.Size(100, 23);
            this.lblSerchProductCode.TabIndex = 4;
            // 
            // lblSerchProductPrice
            // 
            this.lblSerchProductPrice.BackColor = System.Drawing.Color.White;
            this.lblSerchProductPrice.Location = new System.Drawing.Point(305, 113);
            this.lblSerchProductPrice.Name = "lblSerchProductPrice";
            this.lblSerchProductPrice.Size = new System.Drawing.Size(100, 23);
            this.lblSerchProductPrice.TabIndex = 4;
            // 
            // lblSerchProductSalePrice
            // 
            this.lblSerchProductSalePrice.BackColor = System.Drawing.Color.White;
            this.lblSerchProductSalePrice.Location = new System.Drawing.Point(305, 154);
            this.lblSerchProductSalePrice.Name = "lblSerchProductSalePrice";
            this.lblSerchProductSalePrice.Size = new System.Drawing.Size(100, 23);
            this.lblSerchProductSalePrice.TabIndex = 4;
            // 
            // lblSerchProductStock
            // 
            this.lblSerchProductStock.BackColor = System.Drawing.Color.White;
            this.lblSerchProductStock.Location = new System.Drawing.Point(305, 195);
            this.lblSerchProductStock.Name = "lblSerchProductStock";
            this.lblSerchProductStock.Size = new System.Drawing.Size(100, 23);
            this.lblSerchProductStock.TabIndex = 4;
            // 
            // lblSerchProductRegDate
            // 
            this.lblSerchProductRegDate.BackColor = System.Drawing.Color.White;
            this.lblSerchProductRegDate.Location = new System.Drawing.Point(305, 236);
            this.lblSerchProductRegDate.Name = "lblSerchProductRegDate";
            this.lblSerchProductRegDate.Size = new System.Drawing.Size(100, 23);
            this.lblSerchProductRegDate.TabIndex = 4;
            // 
            // lblSerchProductTotalPrice
            // 
            this.lblSerchProductTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblSerchProductTotalPrice.Location = new System.Drawing.Point(305, 350);
            this.lblSerchProductTotalPrice.Name = "lblSerchProductTotalPrice";
            this.lblSerchProductTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.lblSerchProductTotalPrice.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxSerch);
            this.Controls.Add(this.gbxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.gbxSerch.ResumeLayout(false);
            this.gbxSerch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.TextBox tbxSerchProductCount;
        private System.Windows.Forms.TextBox tbxSerchNameCode;
        private System.Windows.Forms.TextBox tbxInputProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSerch;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxSerchProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxInputProductStock;
        private System.Windows.Forms.TextBox tbxInputProductPrice;
        private System.Windows.Forms.Label lblSerchProductRegDate;
        private System.Windows.Forms.Label lblSerchProductStock;
        private System.Windows.Forms.Label lblSerchProductSalePrice;
        private System.Windows.Forms.Label lblSerchProductPrice;
        private System.Windows.Forms.Label lblSerchProductCode;
        private System.Windows.Forms.Label lblSerchProductName;
        private System.Windows.Forms.Label lblSerchProductTotalPrice;
    }
}

