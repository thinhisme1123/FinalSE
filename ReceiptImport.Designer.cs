namespace FinalProjectSE
{
    partial class ReceiptImport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idReceipt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idAccountant = new System.Windows.Forms.TextBox();
            this.createDate = new System.Windows.Forms.DateTimePicker();
            this.createBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idProduct = new System.Windows.Forms.TextBox();
            this.namePro = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtReceipt = new System.Windows.Forms.DataGridView();
            this.itemInfor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Controls.Add(this.createDate);
            this.groupBox1.Controls.Add(this.idAccountant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idReceipt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(773, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Receipt";
            // 
            // idReceipt
            // 
            this.idReceipt.Location = new System.Drawing.Point(118, 29);
            this.idReceipt.Name = "idReceipt";
            this.idReceipt.Size = new System.Drawing.Size(229, 22);
            this.idReceipt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Accountant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creation Date";
            // 
            // idAccountant
            // 
            this.idAccountant.Location = new System.Drawing.Point(118, 68);
            this.idAccountant.Name = "idAccountant";
            this.idAccountant.Size = new System.Drawing.Size(229, 22);
            this.idAccountant.TabIndex = 4;
            // 
            // createDate
            // 
            this.createDate.Location = new System.Drawing.Point(118, 119);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(222, 22);
            this.createDate.TabIndex = 5;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(118, 155);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(134, 36);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create Receipt";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtReceipt);
            this.groupBox3.Location = new System.Drawing.Point(5, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 333);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail Receipt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.Quantity);
            this.groupBox4.Controls.Add(this.price);
            this.groupBox4.Controls.Add(this.namePro);
            this.groupBox4.Controls.Add(this.idProduct);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(561, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 229);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price per product";
            // 
            // idProduct
            // 
            this.idProduct.Location = new System.Drawing.Point(157, 29);
            this.idProduct.Name = "idProduct";
            this.idProduct.Size = new System.Drawing.Size(229, 22);
            this.idProduct.TabIndex = 6;
            // 
            // namePro
            // 
            this.namePro.Location = new System.Drawing.Point(157, 72);
            this.namePro.Name = "namePro";
            this.namePro.Size = new System.Drawing.Size(229, 22);
            this.namePro.TabIndex = 10;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(157, 150);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(229, 22);
            this.price.TabIndex = 11;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(157, 109);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(229, 22);
            this.Quantity.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.itemInfor);
            this.groupBox5.Location = new System.Drawing.Point(532, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 291);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Item Information";
            // 
            // dtReceipt
            // 
            this.dtReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReceipt.Location = new System.Drawing.Point(1, 21);
            this.dtReceipt.Name = "dtReceipt";
            this.dtReceipt.RowHeadersWidth = 51;
            this.dtReceipt.RowTemplate.Height = 24;
            this.dtReceipt.Size = new System.Drawing.Size(514, 303);
            this.dtReceipt.TabIndex = 0;
            // 
            // itemInfor
            // 
            this.itemInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemInfor.Location = new System.Drawing.Point(6, 21);
            this.itemInfor.Name = "itemInfor";
            this.itemInfor.RowHeadersWidth = 51;
            this.itemInfor.RowTemplate.Height = 24;
            this.itemInfor.Size = new System.Drawing.Size(499, 264);
            this.itemInfor.TabIndex = 1;
            // 
            // ReceiptImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 550);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReceiptImport";
            this.Text = "ReceiptImport";
            this.Load += new System.EventHandler(this.ReceiptImport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DateTimePicker createDate;
        private System.Windows.Forms.TextBox idAccountant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox namePro;
        private System.Windows.Forms.TextBox idProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtReceipt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView itemInfor;
    }
}