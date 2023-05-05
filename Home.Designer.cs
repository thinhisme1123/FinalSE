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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // receiptImport
            // 
            this.receiptImport.Location = new System.Drawing.Point(296, 99);
            this.receiptImport.Name = "receiptImport";
            this.receiptImport.Size = new System.Drawing.Size(144, 36);
            this.receiptImport.TabIndex = 1;
            this.receiptImport.Text = "Receipt Import";
            this.receiptImport.UseVisualStyleBackColor = true;
            this.receiptImport.Click += new System.EventHandler(this.receiptImport_Click);
            // 
            // delBill
            // 
            this.delBill.Location = new System.Drawing.Point(480, 99);
            this.delBill.Name = "delBill";
            this.delBill.Size = new System.Drawing.Size(144, 36);
            this.delBill.TabIndex = 2;
            this.delBill.Text = "Delivery Bill";
            this.delBill.UseVisualStyleBackColor = true;
            this.delBill.Click += new System.EventHandler(this.delBill_Click);
            // 
            // revenMonth
            // 
            this.revenMonth.Location = new System.Drawing.Point(314, 168);
            this.revenMonth.Name = "revenMonth";
            this.revenMonth.Size = new System.Drawing.Size(144, 36);
            this.revenMonth.TabIndex = 3;
            this.revenMonth.Text = "Revenue Monthly";
            this.revenMonth.UseVisualStyleBackColor = true;
            this.revenMonth.Click += new System.EventHandler(this.revenMonth_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.revenMonth);
            this.Controls.Add(this.delBill);
            this.Controls.Add(this.receiptImport);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button receiptImport;
        private System.Windows.Forms.Button delBill;
        private System.Windows.Forms.Button revenMonth;
    }
}