using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSE
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        // manage item
        private void button1_Click(object sender, EventArgs e)
        {
            MangeProduct productManage = new MangeProduct();
            this.Hide();
            productManage.ShowDialog();
            this.Close();
        }

        private void receiptImport_Click(object sender, EventArgs e)
        {
            ReceiptImport receiptImport = new ReceiptImport();
            this.Hide();
            receiptImport.ShowDialog();
            this.Close();
    
        }

        private void delBill_Click(object sender, EventArgs e)
        {
            DeliveryBill deliveryBill = new DeliveryBill();
            this.Hide();
            deliveryBill.ShowDialog();
            this.Close();

        }

        private void revenMonth_Click(object sender, EventArgs e)
        {
            RevenueMonthly revenMonthly = new RevenueMonthly();
            this.Hide();
            revenMonthly.ShowDialog();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            agentAdd aa = new agentAdd();
            this.Hide();
            aa.ShowDialog();
            this.Close();
        }
    }
}
