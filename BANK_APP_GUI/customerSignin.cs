using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_APP_GUI
{
    public partial class customerSignin : Form
    {
        public customerSignin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!errorLabel.Visible)
            {
                int ssn = Convert.ToInt32(customerSSN.Text);
                customerInterface customer_interface = new customerInterface(ssn);
                customer_interface.Show();
                this.Hide();
            }
        }
        public static bool CheckSSN(string ssn)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM CUSTOMER";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["SSN"].ToString() == ssn.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void customerSSN_TextChanged(object sender, EventArgs e)
        {
            customerSSN.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerSSN.Text == "")
            {
                errorLabel.Text = "Please enter your SSN";
                errorLabel.Visible = true;
            }
            else
            {
                if (!CheckSSN(customerSSN.Text))
                {
                    errorLabel.Text = "Please enter a valid SSN";
                    errorLabel.Visible = true;

                }
                else
                {
                    errorLabel.Visible = false;
                }

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new signin();
            newframe.Show();
            Visible = false;
        }
    }
}
