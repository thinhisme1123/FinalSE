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
    public partial class MangeProduct : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public MangeProduct()
        {
            InitializeComponent();
        }

        private void MangeProduct_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
        }

        private void findBtnName_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductImport where productName like '%" + nameInput.Text +"%'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }

        private void findBtnid_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductImport where idProduct like '%" + idInput.Text + "%'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductImport";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductExport";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }

        private void findNameEx_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductExport where productName like '%" + nameInputEx.Text + "%'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }
        //find id ex
        private void findBtnEx_Click(object sender, EventArgs e)
        {
            string sql = "select * from manageProductExport where idProduct like '%" + idInputEx.Text + "%'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }
    }
}
