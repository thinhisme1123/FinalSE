using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalProjectSE
{
    public partial class ReceiptImport : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public ReceiptImport()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptImport_Load(object sender, EventArgs e)
        {
            cn= new SqlConnection(strConn);
            cn.Open();
        }
        int dk = 0;
        private void createBtn_Click(object sender, EventArgs e)
        {
            //check user add item before create receipt
            if(dk == 0)
            {
                MessageBox.Show("You must add item first !");
            }
            else
            {
                MessageBox.Show("Create Successfully !");
                string calcTotalPrice = "SELECT SUM(quantity * price) AS totalPrice FROM productInfor";
                data = new SqlDataAdapter(calcTotalPrice, cn);
                tb = new DataTable();
                data.Fill(tb);

                // Retrieve the total price as a single value from the first row and first column of the DataTable
                int totalPrice = (int)tb.Rows[0]["totalPrice"];

                string createReceipt = "insert into detailReceipt (idReceipt,idAccountant,creationData,totalPrice,goods) values (@idReceipt,@idAccountant,@creationData,@totalPrice,(SELECT STRING_AGG(idProduct, ',') FROM productInfor))";
                cm = new SqlCommand(createReceipt, cn);
                cm.Parameters.AddWithValue("@idReceipt", idReceipt.Text);
                cm.Parameters.AddWithValue("@idAccountant", idAccountant.Text);
                cm.Parameters.AddWithValue("@creationData", createDate.Value.ToString("yyyy-MM-dd"));
                cm.Parameters.AddWithValue("@totalPrice", totalPrice);

                int rowsAffected = cm.ExecuteNonQuery();

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Create receipt import successfully !!");
                    string sql = "select * from detailReceipt";
                    data = new SqlDataAdapter(sql, cn);
                    tb = new DataTable();
                    data.Fill(tb);
                    dtReceipt.DataSource = tb;
                    //delete all data in productInfor, reset to the empty
                    //string deleteProinfo = "delete from productInfor";
                    //SqlCommand deleProinfo = new SqlCommand(deleteProinfo, cn);
                    //deleProinfo.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error: Customer record not inserted.");
                }

            }

        }
        //add item btn
        private void button2_Click(object sender, EventArgs e)
        {
            dk = 1;
            //adding prouct to product infor
            string addItem = "insert into productInfor values (@proId,@proName,@quantity,@price)";
            cm = new SqlCommand(addItem, cn);
            cm.Parameters.AddWithValue("@proId", idProduct.Text);
            cm.Parameters.AddWithValue("@proName", namePro.Text);
            cm.Parameters.AddWithValue("@quantity", Quantity.Text);
            cm.Parameters.AddWithValue("@price", price.Text);
            //update 
            string updateQuantity = "update manageProductImport set availabelQuantity = availabelQuantity + @quantity where idProduct = @idProduct";
            SqlCommand upavaiQauntity = new SqlCommand(updateQuantity, cn);
            upavaiQauntity.Parameters.AddWithValue("quantity", Quantity.Text);
            upavaiQauntity.Parameters.AddWithValue("idProduct", idProduct.Text);



            //adding product to mamnage product
            string addManage = "insert into manageProductImport values (@proId,@proName,@quantitySold,@availabelQuantity,@price)";
            SqlCommand cm1 = new SqlCommand(addManage, cn);
            cm1.Parameters.AddWithValue("@proId", idProduct.Text);
            cm1.Parameters.AddWithValue("@proName", namePro.Text);
            cm1.Parameters.AddWithValue("@quantitySold", 0);
            cm1.Parameters.AddWithValue("@availabelQuantity", Quantity.Text);
            cm1.Parameters.AddWithValue("@price", price.Text);



            // Execute the query
            int rowsAffected = cm.ExecuteNonQuery();
            int rowsAddmanage = cm1.ExecuteNonQuery();

            if (rowsAddmanage == 1)
            {
                MessageBox.Show("Adding Item Successfully. Next please create receipt import !");
            }
            else
            {
                MessageBox.Show("Error: Customer record not inserted.");
            }
            // show infor to the grd
            string sql = "select * from productInfor";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            itemInfor.DataSource = tb;
        }
    }
}
