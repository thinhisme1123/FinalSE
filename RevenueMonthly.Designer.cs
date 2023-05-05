namespace FinalProjectSE
{
    partial class RevenueMonthly
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.revenueGrd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.revenueGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Revenue Monthly";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // revenueGrd
            // 
            this.revenueGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenueGrd.Location = new System.Drawing.Point(3, 148);
            this.revenueGrd.Name = "revenueGrd";
            this.revenueGrd.RowHeadersWidth = 51;
            this.revenueGrd.RowTemplate.Height = 24;
            this.revenueGrd.Size = new System.Drawing.Size(797, 300);
            this.revenueGrd.TabIndex = 4;
            // 
            // RevenueMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.revenueGrd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "RevenueMonthly";
            this.Text = "RevenueMonthly";
            this.Load += new System.EventHandler(this.RevenueMonthly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView revenueGrd;
    }
}