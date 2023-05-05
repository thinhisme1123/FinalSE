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
    
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            /* try
           {

               string sql = "SELECT * FROM accLogin WHERE username = @Username AND password = @Password";
               data = new SqlDataAdapter(sql, cn);
               data.SelectCommand.Parameters.AddWithValue("@Username", userTxt.Text);
               data.SelectCommand.Parameters.AddWithValue("@Password", passTxt.Text);

               tb = new DataTable();
               data.Fill(tb);

               if (tb.Rows.Count == 1)
               {
                   Home home = new Home();
                   home.Show();
                   this.Visible = false;
               }
               else
               {
                   MessageBox.Show("Invalid username or password.");
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error: " + ex.Message);
           } */

            Home home = new Home();
            home.Show();
            this.Visible = false;
        }
        // exit program
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
