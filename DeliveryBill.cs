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
    public partial class DeliveryBill : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public DeliveryBill()
        {
            InitializeComponent();
        }

        private void DeliveryBill_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();

        }
        //create delivery bill clicking
        private void button1_Click(object sender, EventArgs e)
        {
            //adding data to deliveryBill 
            string createDelBill = "insert into deliveryBill values (@id,@idAccountant,@disID,@disName,@pmMethod,@pmStatus,@orStatus,@idProduct,@quantity,@createDate)";
            cm = new SqlCommand(createDelBill, cn);
            cm.Parameters.AddWithValue("@id", idDel.Text);
            cm.Parameters.AddWithValue("@idAccountant", idAccountant.Text);
            cm.Parameters.AddWithValue("@disID", idDis.Text);
            cm.Parameters.AddWithValue("@disName", nameDis.Text);
            cm.Parameters.AddWithValue("@pmMethod", pmMethod.Text);
            cm.Parameters.AddWithValue("@pmStatus", pmStatus.Text);
            cm.Parameters.AddWithValue("@orStatus", orderStatus.Text);
            cm.Parameters.AddWithValue("@idProduct", idProduct.Text);
            cm.Parameters.AddWithValue("@quantity", quantity.Text);
            cm.Parameters.AddWithValue("@createDate", dataDelivery.Value.ToString("yyyy-MM-dd"));

            int rowsAffected = cm.ExecuteNonQuery();

            if (rowsAffected == 1)
            {
                MessageBox.Show("Create delivery bill successfully.");
                string query = @"INSERT INTO revenueMonth (time, revenueMonthly)
                            SELECT DATEFROMPARTS(YEAR(createDate), MONTH(createDate), 1) AS time,
                                   SUM(mp.quantitySold * p.price) AS revenueMonthly
                            FROM deliveryBill db
                            JOIN manageProductExport mp ON db.idProduct = mp.idProduct
                            JOIN productInfor p ON db.idProduct = p.idProduct
                            GROUP BY YEAR(createDate), MONTH(createDate)";
                cm = new SqlCommand(query, cn);
                cm.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Error: Not adding yet");
            }
            //update quantity solde in table manageProductImport
            string updateManageProduct = "UPDATE manageProductImport SET quantitySold = @quantity WHERE idProduct = @idProduct";
            cm = new SqlCommand(updateManageProduct, cn);
            cm.Parameters.AddWithValue("@idProduct", idProduct.Text);
            cm.Parameters.AddWithValue("@quantity", quantity.Text);
            // Execute the update statement to update the quantity in the manageProduct table
            cm.ExecuteNonQuery();

            // Insert a new row into the manageProductExport table with the same proName as the corresponding row in the manageProductImport table
            string createMPExport = "INSERT INTO manageProductExport (idProduct, productName, quantitySold,price) VALUES (@proId, (SELECT productName FROM manageProductImport WHERE idProduct = @idProduct), @quantitySold, (SELECT price FROM productInfor WHERE idProduct = @idProduct))";
            SqlCommand cm1 = new SqlCommand(createMPExport, cn);
            cm1.Parameters.AddWithValue("@idProduct", idProduct.Text);
            cm1.Parameters.AddWithValue("@proId", idProduct.Text);
            cm1.Parameters.AddWithValue("@quantitySold", quantity.Text);

            cm1.ExecuteNonQuery();

            int checkAddingMGI = cm.ExecuteNonQuery();
            int checkAddingMGE = cm1.ExecuteNonQuery();


            if (checkAddingMGI == 1 && checkAddingMGE == 1)
            {
               string sql = "select * from deliveryBill";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                delBillgrd.DataSource = tb;
            }
            else
            {
                MessageBox.Show("Error");
            } 

        }
    }
}
