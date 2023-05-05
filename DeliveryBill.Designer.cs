namespace FinalProjectSE
{
    partial class DeliveryBill
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
            this.quantity = new System.Windows.Forms.TextBox();
            this.idProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameDis = new System.Windows.Forms.TextBox();
            this.idAccountant = new System.Windows.Forms.TextBox();
            this.orderStatus = new System.Windows.Forms.ComboBox();
            this.pmStatus = new System.Windows.Forms.ComboBox();
            this.pmMethod = new System.Windows.Forms.ComboBox();
            this.idDis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delBillgrd = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dataDelivery = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delBillgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataDelivery);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.idProduct);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nameDis);
            this.groupBox1.Controls.Add(this.idAccountant);
            this.groupBox1.Controls.Add(this.orderStatus);
            this.groupBox1.Controls.Add(this.pmStatus);
            this.groupBox1.Controls.Add(this.pmMethod);
            this.groupBox1.Controls.Add(this.idDis);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idDel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(407, 152);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(174, 22);
            this.quantity.TabIndex = 18;
            // 
            // idProduct
            // 
            this.idProduct.Location = new System.Drawing.Point(407, 112);
            this.idProduct.Name = "idProduct";
            this.idProduct.Size = new System.Drawing.Size(174, 22);
            this.idProduct.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create Delivery Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameDis
            // 
            this.nameDis.Location = new System.Drawing.Point(407, 72);
            this.nameDis.Name = "nameDis";
            this.nameDis.Size = new System.Drawing.Size(174, 22);
            this.nameDis.TabIndex = 13;
            // 
            // idAccountant
            // 
            this.idAccountant.Location = new System.Drawing.Point(407, 28);
            this.idAccountant.Name = "idAccountant";
            this.idAccountant.Size = new System.Drawing.Size(174, 22);
            this.idAccountant.TabIndex = 12;
            // 
            // orderStatus
            // 
            this.orderStatus.FormattingEnabled = true;
            this.orderStatus.Items.AddRange(new object[] {
            "Being tranported",
            "Delivered"});
            this.orderStatus.Location = new System.Drawing.Point(115, 191);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(173, 24);
            this.orderStatus.TabIndex = 11;
            // 
            // pmStatus
            // 
            this.pmStatus.FormattingEnabled = true;
            this.pmStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.pmStatus.Location = new System.Drawing.Point(115, 152);
            this.pmStatus.Name = "pmStatus";
            this.pmStatus.Size = new System.Drawing.Size(173, 24);
            this.pmStatus.TabIndex = 10;
            // 
            // pmMethod
            // 
            this.pmMethod.FormattingEnabled = true;
            this.pmMethod.Items.AddRange(new object[] {
            "Zalo pay",
            "VN Pay",
            "Credit Card",
            "Momo"});
            this.pmMethod.Location = new System.Drawing.Point(114, 108);
            this.pmMethod.Name = "pmMethod";
            this.pmMethod.Size = new System.Drawing.Size(173, 24);
            this.pmMethod.TabIndex = 9;
            // 
            // idDis
            // 
            this.idDis.Location = new System.Drawing.Point(114, 69);
            this.idDis.Name = "idDis";
            this.idDis.Size = new System.Drawing.Size(174, 22);
            this.idDis.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Distributor Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID Accountant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Order Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payment Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distributor ID";
            // 
            // idDel
            // 
            this.idDel.Location = new System.Drawing.Point(114, 28);
            this.idDel.Name = "idDel";
            this.idDel.Size = new System.Drawing.Size(174, 22);
            this.idDel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delBillgrd);
            this.groupBox2.Location = new System.Drawing.Point(-1, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1052, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery Bill";
            // 
            // delBillgrd
            // 
            this.delBillgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delBillgrd.Location = new System.Drawing.Point(6, 21);
            this.delBillgrd.Name = "delBillgrd";
            this.delBillgrd.RowHeadersWidth = 51;
            this.delBillgrd.RowTemplate.Height = 24;
            this.delBillgrd.Size = new System.Drawing.Size(1046, 314);
            this.delBillgrd.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Creation Date";
            // 
            // dataDelivery
            // 
            this.dataDelivery.Location = new System.Drawing.Point(412, 193);
            this.dataDelivery.Name = "dataDelivery";
            this.dataDelivery.Size = new System.Drawing.Size(168, 22);
            this.dataDelivery.TabIndex = 20;
            // 
            // DeliveryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeliveryBill";
            this.Text = "DeliveryBill";
            this.Load += new System.EventHandler(this.DeliveryBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delBillgrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameDis;
        private System.Windows.Forms.TextBox idAccountant;
        private System.Windows.Forms.ComboBox orderStatus;
        private System.Windows.Forms.ComboBox pmStatus;
        private System.Windows.Forms.ComboBox pmMethod;
        private System.Windows.Forms.TextBox idDis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView delBillgrd;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox idProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dataDelivery;
        private System.Windows.Forms.Label label10;
    }
}