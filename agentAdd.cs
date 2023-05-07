using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSE
{
    public partial class agentAdd : Form
    {
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
        }

        private void agentAdd_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTxt.Text) || string.IsNullOrWhiteSpace(nameTxt.Text) || string.IsNullOrWhiteSpace(passTxt.Text))
            {
                addBtn.Enabled= false;
            } else
            {
                addBtn.Enabled = true;
            }
        }
    }
}
