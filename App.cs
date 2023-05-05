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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        private void staffSection_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void agentSection_Click(object sender, EventArgs e)
        {

        }
    }
}
