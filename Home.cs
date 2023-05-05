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
            productManage.ShowDialog();
        }

        private void receiptImport_Click(object sender, EventArgs e)
        {
            ReceiptImport receiptImport = new ReceiptImport();
            receiptImport.ShowDialog();
    
        }

        private void delBill_Click(object sender, EventArgs e)
        {
            DeliveryBill deliveryBill = new DeliveryBill();
            deliveryBill.ShowDialog();

        }

        private void revenMonth_Click(object sender, EventArgs e)
        {
            RevenueMonthly revenMonthly = new RevenueMonthly();
            revenMonthly.ShowDialog();
        }
    }
}
