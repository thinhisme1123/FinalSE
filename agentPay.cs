using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProjectSE
{
    public partial class agentPay : Form
    {
        bool createWasClicked = false;
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public static string price = "0";
        public agentPay()
        {
            InitializeComponent();
        }

        void showData()
        {
            string sql = "select * from goodOrder";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            agentOrder.check = 1;
            agentOrder ao = new agentOrder();
            this.Hide();
            ao.ShowDialog();
            this.Close();
        }

        private void agentPay_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
            priceTxt.Enabled = false;
            priceTxt.Text = agentOrder.price.ToString();
            price = agentOrder.price;
            showData();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createWasClicked = true;
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var MyData = qr.CreateQrCode("ashjkdhasjkdhasjkhdkjashdkjsahkdjashjkdashjkdhas", QRCoder.QRCodeGenerator.ECCLevel.Q);
            var code = new QRCoder.QRCode(MyData);
            qrBox.Image = code.GetGraphic(50);
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (!createWasClicked)
            {
                MessageBox.Show("Please choose payment method and pay!");
                return;
            }   
            MessageBox.Show("Successfull!");
            agentOrder ao = new agentOrder();
            this.Hide();
            ao.ShowDialog();
            this.Close();
        }
    }
}
