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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mobile Phone Products App";
            // 
            // agentSection
            // 
            this.agentSection.BackColor = System.Drawing.Color.PapayaWhip;
            this.agentSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agentSection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.agentSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentSection.Location = new System.Drawing.Point(134, 273);
            this.agentSection.Name = "agentSection";
            this.agentSection.Size = new System.Drawing.Size(142, 50);
            this.agentSection.TabIndex = 1;
            this.agentSection.Text = "Agent";
            this.agentSection.UseVisualStyleBackColor = false;
            this.agentSection.Click += new System.EventHandler(this.agentSection_Click);
            // 
            // staffSection
            // 
            this.staffSection.BackColor = System.Drawing.Color.PapayaWhip;
            this.staffSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.staffSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffSection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.staffSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSection.Location = new System.Drawing.Point(530, 273);
            this.staffSection.Name = "staffSection";
            this.staffSection.Size = new System.Drawing.Size(142, 50);
            this.staffSection.TabIndex = 3;
            this.staffSection.Text = "Staff";
            this.staffSection.UseVisualStyleBackColor = false;
            this.staffSection.Click += new System.EventHandler(this.staffSection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(227, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please choose section to use:";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffSection);
            this.Controls.Add(this.agentSection);
            this.Controls.Add(this.label1);
            this.Name = "App";
            this.Text = "Mobile Phone Product App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agentSection;
        private System.Windows.Forms.Button staffSection;
        private System.Windows.Forms.Label label2;
    }
}