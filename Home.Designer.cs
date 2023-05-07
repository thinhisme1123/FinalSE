namespace FinalProjectSE
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.receiptImport = new System.Windows.Forms.Button();
            this.delBill = new System.Windows.Forms.Button();
            this.revenMonth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // receiptImport
            // 
            this.receiptImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptImport.Location = new System.Drawing.Point(167, 115);
            this.receiptImport.Name = "receiptImport";
            this.receiptImport.Size = new System.Drawing.Size(162, 62);
            this.receiptImport.TabIndex = 1;
            this.receiptImport.Text = "Receipt Import";
            this.receiptImport.UseVisualStyleBackColor = true;
            this.receiptImport.Click += new System.EventHandler(this.receiptImport_Click);
            // 
            // delBill
            // 
            this.delBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBill.Location = new System.Drawing.Point(494, 115);
            this.delBill.Name = "delBill";
            this.delBill.Size = new System.Drawing.Size(162, 62);
            this.delBill.TabIndex = 2;
            this.delBill.Text = "Delivery Bill";
            this.delBill.UseVisualStyleBackColor = true;
            this.delBill.Click += new System.EventHandler(this.delBill_Click);
            // 
            // revenMonth
            // 
            this.revenMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenMonth.Location = new System.Drawing.Point(494, 254);
            this.revenMonth.Name = "revenMonth";
            this.revenMonth.Size = new System.Drawing.Size(162, 62);
            this.revenMonth.TabIndex = 3;
            this.revenMonth.Text = "Revenue Monthly";
            this.revenMonth.UseVisualStyleBackColor = true;
            this.revenMonth.Click += new System.EventHandler(this.revenMonth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(222, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Choose Function";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 396);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(114, 42);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(626, 365);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(162, 62);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Agent";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.revenMonth);
            this.Controls.Add(this.delBill);
            this.Controls.Add(this.receiptImport);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button receiptImport;
        private System.Windows.Forms.Button delBill;
        private System.Windows.Forms.Button revenMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
    }
}