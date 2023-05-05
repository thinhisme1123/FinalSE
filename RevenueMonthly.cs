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
    public partial class RevenueMonthly : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public RevenueMonthly()
        {
            InitializeComponent();
        }

        private void RevenueMonthly_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from revenueMonth";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            revenueGrd.DataSource = tb;
        }
    }
}
