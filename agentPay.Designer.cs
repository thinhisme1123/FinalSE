namespace FinalProjectSE
{
    partial class agentPay
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
            this.payCb = new System.Windows.Forms.ComboBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.qrBox = new System.Windows.Forms.PictureBox();
            this.createBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(114, 42);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(313, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select payment method:";
            // 
            // payCb
            // 
            this.payCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.payCb.FormattingEnabled = true;
            this.payCb.Items.AddRange(new object[] {
            "VNPay",
            "ZaloPay",
            "Momo",
            "Cash",
            "Credit"});
            this.payCb.Location = new System.Drawing.Point(593, 57);
            this.payCb.Name = "payCb";
            this.payCb.Size = new System.Drawing.Size(195, 28);
            this.payCb.TabIndex = 21;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(117, 60);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(166, 22);
            this.priceTxt.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(9, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total Price";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(6, 21);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 51;
            this.grd.RowTemplate.Height = 24;
            this.grd.Size = new System.Drawing.Size(764, 210);
            this.grd.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 192);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // payBtn
            // 
            this.payBtn.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.Location = new System.Drawing.Point(674, 198);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(114, 42);
            this.payBtn.TabIndex = 32;
            this.payBtn.Text = "PAY";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "QR Code";
            // 
            // qrBox
            // 
            this.qrBox.Location = new System.Drawing.Point(293, 98);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(167, 142);
            this.qrBox.TabIndex = 34;
            this.qrBox.TabStop = false;
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(674, 91);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(97, 27);
            this.createBtn.TabIndex = 35;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // agentPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.qrBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.payCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Name = "agentPay";
            this.Text = "Mobile Phone Product App";
            this.Load += new System.EventHandler(this.agentPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox payCb;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox qrBox;
        private System.Windows.Forms.Button createBtn;
    }
}