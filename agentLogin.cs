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
    public partial class agentLogin : Form
    {
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
            agentOrder ao = new agentOrder();
            this.Hide();
            ao.ShowDialog();
            this.Close();
        }
    }
}
