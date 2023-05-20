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
    public partial class employeeInterface : Form
    {
        public employeeInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateCustomer updateCustomer = new updateCustomer();
            updateCustomer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addCustomer addCustomer = new addCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void employeeInterface_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updateCustomer updateCustomer = new updateCustomer();
            updateCustomer.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addCustomer addCustomer = new addCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new employee_signin();
            newframe.Show();
            this.Hide();
        }
    }
}
