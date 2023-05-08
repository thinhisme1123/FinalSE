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
    public partial class agentAdd : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public agentAdd()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(idTxt.Text) || string.IsNullOrEmpty(passTxt.Text))
            {
                MessageBox.Show("Not enough information!");
            } else
            {
                int checkVar = 0;

                string sqlName = "select agentName from agentInfo where agentName = '" + nameTxt.Text + "'";
                cm = new SqlCommand(sqlName, cn);
                SqlDataReader readerName = cm.ExecuteReader();
                if (readerName.HasRows)
                {
                    checkVar = 1;
                    MessageBox.Show("This Agent has existed!");
                }
                readerName.Close();

                string sqlID = "select agentID from agentInfo where agentID = '" + idTxt.Text + "'";
                cm = new SqlCommand(sqlID, cn);
                SqlDataReader readerID = cm.ExecuteReader();
                if (readerID.HasRows)
                {
                    checkVar = 1;
                    MessageBox.Show("This AgentID has existed!");
                }
                readerID.Close();

                if (checkVar == 0)
                {
                    string sqlAdd = "insert into agentInfo (agentID, agentName, agentpass) values (@agentid, @agentname, @agentpass)";
                    cm = new SqlCommand(sqlAdd, cn);
                    cm.Parameters.AddWithValue("@agentid", idTxt.Text);
                    cm.Parameters.AddWithValue("@agentname", nameTxt.Text);
                    cm.Parameters.AddWithValue("@agentpass", passTxt.Text);

                    int rowsAffected = cm.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Success!");
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("Error: Customer record not inserted.");
                    }
                }
            }
        }
        public void showData()
        {
            string sql = "select * from agentInfo";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void agentAdd_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
            showData();
        }
    }
}
