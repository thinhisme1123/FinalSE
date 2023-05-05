namespace FinalProjectSE
{
    partial class App
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
            this.agentSection = new System.Windows.Forms.Button();
            this.staffSection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(313, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage App";
            // 
            // agentSection
            // 
            this.agentSection.Location = new System.Drawing.Point(198, 147);
            this.agentSection.Name = "agentSection";
            this.agentSection.Size = new System.Drawing.Size(142, 50);
            this.agentSection.TabIndex = 1;
            this.agentSection.Text = "Agent";
            this.agentSection.UseVisualStyleBackColor = true;
            this.agentSection.Click += new System.EventHandler(this.agentSection_Click);
            // 
            // staffSection
            // 
            this.staffSection.Location = new System.Drawing.Point(426, 147);
            this.staffSection.Name = "staffSection";
            this.staffSection.Size = new System.Drawing.Size(142, 50);
            this.staffSection.TabIndex = 3;
            this.staffSection.Text = "Staff";
            this.staffSection.UseVisualStyleBackColor = true;
            this.staffSection.Click += new System.EventHandler(this.staffSection_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffSection);
            this.Controls.Add(this.agentSection);
            this.Controls.Add(this.label1);
            this.Name = "App";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agentSection;
        private System.Windows.Forms.Button staffSection;
    }
}