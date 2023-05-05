namespace FinalProjectSE
{
    partial class MangeProduct
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
            this.productGrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.findBtnName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.findBtnid = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findIDEx = new System.Windows.Forms.Button();
            this.idInputEx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.findNameEx = new System.Windows.Forms.Button();
            this.nameInputEx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productGrd
            // 
            this.productGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrd.Location = new System.Drawing.Point(12, 197);
            this.productGrd.Name = "productGrd";
            this.productGrd.RowHeadersWidth = 51;
            this.productGrd.RowTemplate.Height = 24;
            this.productGrd.Size = new System.Drawing.Size(951, 261);
            this.productGrd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "FInd Item by Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(137, 20);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(191, 22);
            this.nameInput.TabIndex = 3;
            // 
            // findBtnName
            // 
            this.findBtnName.Location = new System.Drawing.Point(334, 21);
            this.findBtnName.Name = "findBtnName";
            this.findBtnName.Size = new System.Drawing.Size(113, 23);
            this.findBtnName.TabIndex = 5;
            this.findBtnName.Text = "FInd Name";
            this.findBtnName.UseVisualStyleBackColor = true;
            this.findBtnName.Click += new System.EventHandler(this.findBtnName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "FInd Item by ID";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(137, 65);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(191, 22);
            this.idInput.TabIndex = 7;
            // 
            // findBtnid
            // 
            this.findBtnid.Location = new System.Drawing.Point(334, 64);
            this.findBtnid.Name = "findBtnid";
            this.findBtnid.Size = new System.Drawing.Size(75, 23);
            this.findBtnid.TabIndex = 8;
            this.findBtnid.Text = "FInd ID";
            this.findBtnid.UseVisualStyleBackColor = true;
            this.findBtnid.Click += new System.EventHandler(this.findBtnid_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(156, 102);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(159, 24);
            this.exportBtn.TabIndex = 10;
            this.exportBtn.Text = "List Export Product";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(150, 93);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(159, 24);
            this.importBtn.TabIndex = 11;
            this.importBtn.Text = "List Import Product";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importBtn);
            this.groupBox1.Controls.Add(this.findBtnid);
            this.groupBox1.Controls.Add(this.idInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.findBtnName);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 134);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.findIDEx);
            this.groupBox2.Controls.Add(this.idInputEx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.findNameEx);
            this.groupBox2.Controls.Add(this.nameInputEx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.exportBtn);
            this.groupBox2.Location = new System.Drawing.Point(482, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 131);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // findIDEx
            // 
            this.findIDEx.Location = new System.Drawing.Point(328, 69);
            this.findIDEx.Name = "findIDEx";
            this.findIDEx.Size = new System.Drawing.Size(75, 23);
            this.findIDEx.TabIndex = 12;
            this.findIDEx.Text = "FInd ID";
            this.findIDEx.UseVisualStyleBackColor = true;
            this.findIDEx.Click += new System.EventHandler(this.findBtnEx_Click);
            // 
            // idInputEx
            // 
            this.idInputEx.Location = new System.Drawing.Point(131, 66);
            this.idInputEx.Name = "idInputEx";
            this.idInputEx.Size = new System.Drawing.Size(191, 22);
            this.idInputEx.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "FInd Item by ID";
            // 
            // findNameEx
            // 
            this.findNameEx.Location = new System.Drawing.Point(328, 23);
            this.findNameEx.Name = "findNameEx";
            this.findNameEx.Size = new System.Drawing.Size(113, 23);
            this.findNameEx.TabIndex = 12;
            this.findNameEx.Text = "FInd Name";
            this.findNameEx.UseVisualStyleBackColor = true;
            this.findNameEx.Click += new System.EventHandler(this.findNameEx_Click);
            // 
            // nameInputEx
            // 
            this.nameInputEx.Location = new System.Drawing.Point(131, 23);
            this.nameInputEx.Name = "nameInputEx";
            this.nameInputEx.Size = new System.Drawing.Size(191, 22);
            this.nameInputEx.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "FInd Item by Name";
            // 
            // MangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productGrd);
            this.Name = "MangeProduct";
            this.Text = "MangeProduct";
            this.Load += new System.EventHandler(this.MangeProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button findBtnName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Button findBtnid;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button findIDEx;
        private System.Windows.Forms.TextBox idInputEx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findNameEx;
        private System.Windows.Forms.TextBox nameInputEx;
        private System.Windows.Forms.Label label4;
    }
}