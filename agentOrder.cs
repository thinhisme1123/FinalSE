using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSE
{
    public partial class agentOrder : Form
    {

        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public agentOrder()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            agentLogin al = new agentLogin();
            this.Hide();
            al.ShowDialog();
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            agentPay ap = new agentPay();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }

        private void agentOrder_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductImport";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grdGood.DataSource = tb;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string sqlPrice = "select price from manageProductImport where idProduct = '" + idProTxt.Text + "'";
            cm = new SqlCommand(sqlPrice, cn);
            priceTxt.Text = cm.ExecuteNonQuery().ToString();
        }
    }
}
