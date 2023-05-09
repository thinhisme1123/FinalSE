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
        int t = 0;
        public static int check = 0;
        public static string price;
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
            string sql = "delete from goodOrder";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            agentLogin al = new agentLogin();
            this.Hide();
            al.ShowDialog();
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from goodOrder";
            cm = new SqlCommand(sql, cn);
            SqlDataReader reader = cm.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Please choose good to buy!");
                reader.Close();
                return;

            }
            price = priceTxt.Text;
            agentPay ap = new agentPay();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }

        private void agentOrder_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
            priceTxt.Enabled= false;
            idAgentTxt.Text = agentLogin.AgentID;
            idAgentTxt.Enabled = false;
            priceTxt.Text = agentPay.price;
            showData();
            if (check == 0)
            {
                string sql = "delete from goodOrder";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                priceTxt.Text = check.ToString();
            }
            showData();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductImport";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grdGood.DataSource = tb;
        }

        void showData()
        {
            string sql = "select * from goodOrder";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grdOrder.DataSource = tb;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idProTxt.Text) || string.IsNullOrEmpty(qtyTxt.Text))
            {
                MessageBox.Show("Please enter full information!");
            }
            else
            {
                string namePro = "";
                string sql = "select idProduct, productName, price from manageProductImport where idProduct = '" + idProTxt.Text + "'";
                cm = new SqlCommand(sql, cn);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.Read())
                {
                    t = int.Parse(priceTxt.Text) + int.Parse(reader.GetValue(2).ToString()) * int.Parse(qtyTxt.Text);
                    priceTxt.Text = t.ToString();
                    namePro = reader.GetValue(1).ToString();
                }
                reader.Close();
                string sqlInsert = "insert into goodOrder values (@idProduct,@nameProduct,@quantity,@totalPrice)";
                cm = new SqlCommand(sqlInsert, cn);
                cm.Parameters.AddWithValue("@idProduct", idProTxt.Text);
                cm.Parameters.AddWithValue("@nameProduct", namePro);
                cm.Parameters.AddWithValue("@quantity", qtyTxt.Text);
                cm.Parameters.AddWithValue("@totalPrice", priceTxt.Text);
                cm.ExecuteNonQuery();
                showData();
            } 
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sql = "delete from goodOrder";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            showData();
            priceTxt.Text = "0";
        }
    }
}
