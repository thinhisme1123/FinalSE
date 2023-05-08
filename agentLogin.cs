using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSE
{
    public partial class agentLogin : Form
    {

        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public agentLogin()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            App App = new App();
            this.Hide();
            App.ShowDialog();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userTxt.Text) || string.IsNullOrEmpty(passTxt.Text))
            {
                MessageBox.Show("Please enter username and password");
            } 
            else
            {
                string sqlLogin = "select agentName from agentInfo where agentID = '" + userTxt.Text + "' and agentpass = '" + passTxt.Text + "'";
                cm = new SqlCommand(sqlLogin, cn);
                SqlDataReader readerLogin = cm.ExecuteReader();
                if (readerLogin.HasRows)
                {
                    agentOrder ao = new agentOrder();
                    this.Hide();
                    ao.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void agentLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
        }
    }
}
