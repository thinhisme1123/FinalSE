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
    public partial class agentOrder : Form
    {
        public agentOrder()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            agentLogin al = new agentLogin();
            this.Hide();
            al.ShowDialog();
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            agentPay ap = new agentPay();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }
    }
}
