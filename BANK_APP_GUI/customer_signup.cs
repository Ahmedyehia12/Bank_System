using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_APP_GUI
{
    public partial class customer_signup : Form
    {
        public customer_signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information saved\tCustomer signed-up Successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string address = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string phone = textBox3.Text;
            if (phone.Length != 11)
            {

            }
        }
    }
}
