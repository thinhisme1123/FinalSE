namespace FinalProjectSE
{
    partial class agentOrder
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
            if (disposing && (components != null))
            {
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idAgentTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdGood = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.qtyBtn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.idProTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.idBillTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGood)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(114, 42);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order Goods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(57, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Agent ID";
            // 
            // idAgentTxt
            // 
            this.idAgentTxt.Location = new System.Drawing.Point(160, 63);
            this.idAgentTxt.Name = "idAgentTxt";
            this.idAgentTxt.Size = new System.Drawing.Size(166, 22);
            this.idAgentTxt.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdGood);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 274);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goods Information";
            // 
            // grdGood
            // 
            this.grdGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGood.Location = new System.Drawing.Point(6, 21);
            this.grdGood.Name = "grdGood";
            this.grdGood.RowHeadersWidth = 51;
            this.grdGood.RowTemplate.Height = 24;
            this.grdGood.Size = new System.Drawing.Size(365, 247);
            this.grdGood.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(57, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product ID";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(668, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(114, 42);
            this.nextBtn.TabIndex = 22;
            this.nextBtn.Text = "NEXT";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(57, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantity";
            // 
            // qtyBtn
            // 
            this.qtyBtn.Location = new System.Drawing.Point(160, 149);
            this.qtyBtn.Name = "qtyBtn";
            this.qtyBtn.Size = new System.Drawing.Size(166, 22);
            this.qtyBtn.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 38);
            this.label5.TabIndex = 25;
            this.label5.Text = "=>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(492, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total Price";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(600, 116);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(166, 22);
            this.priceTxt.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdOrder);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(411, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 274);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total goods order";
            // 
            // grdOrder
            // 
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Location = new System.Drawing.Point(6, 21);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.RowHeadersWidth = 51;
            this.grdOrder.RowTemplate.Height = 24;
            this.grdOrder.Size = new System.Drawing.Size(365, 247);
            this.grdOrder.TabIndex = 0;
            // 
            // idProTxt
            // 
            this.idProTxt.Location = new System.Drawing.Point(160, 107);
            this.idProTxt.Name = "idProTxt";
            this.idProTxt.Size = new System.Drawing.Size(166, 22);
            this.idProTxt.TabIndex = 29;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(345, 111);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(72, 32);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.Location = new System.Drawing.Point(12, 174);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(82, 32);
            this.showBtn.TabIndex = 31;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // idBillTxt
            // 
            this.idBillTxt.Location = new System.Drawing.Point(452, 63);
            this.idBillTxt.Name = "idBillTxt";
            this.idBillTxt.Size = new System.Drawing.Size(166, 22);
            this.idBillTxt.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(344, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Bill ID";
            // 
            // agentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.idBillTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.idProTxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtyBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idAgentTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Name = "agentOrder";
            this.Text = "Mobile Phone Product App";
            this.Load += new System.EventHandler(this.agentOrder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGood)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idAgentTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qtyBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdOrder;
        private System.Windows.Forms.TextBox idProTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.TextBox idBillTxt;
        private System.Windows.Forms.Label label7;
    }
}