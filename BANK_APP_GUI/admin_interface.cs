using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_APP_GUI
{
    public partial class admin_interface : Form
    {
        public admin_interface()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newframe = new addBank();
            newframe.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newframe = new addBranch();
            newframe.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newframe = new displayAllCustomers();
            newframe.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new signin();
            newframe.Show();
            Visible = false;
        }

        private void admin_interface_Load(object sender, EventArgs e)
        {

        }
    }
}
