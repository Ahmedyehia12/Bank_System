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
    public partial class updateCustomer : Form
    {
        public updateCustomer()
        {
            InitializeComponent();
        }
        public bool isAllFilled()
        {
            if (customerSSN.Text == "" || newName.Text == "" || customerAddress.Text == "" || customerPhone.Text == "" || !CheckSSN(customerSSN.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!errorLabel.Visible && isAllFilled()&&CheckSSN(customerSSN.Text)&&CheckPhone(customerPhone.Text))
            {
                int ssn = Convert.ToInt32(customerSSN.Text);
                string name = newName.Text;
                string address = customerAddress.Text;
                string phone = customerPhone.Text;
                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE CUSTOMER SET CUSTOMER_NAME = @CUSTOMER_NAME, CUSTOMER_PHONE = @CUSTOMER_PHONE, CUSTOMER_ADDRESS = @CUSTOMER_ADDRESS WHERE SSN = @SSN";
                command.Parameters.AddWithValue("@SSN", ssn);
                command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
                command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
                command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer Updated Successfully");
                employeeInterface employee = new employeeInterface();
                employee.Show();
                this.Hide();

            }
            else
            {
                errorLabel.Text = "Please fill all the fields accurately& check any Invalid Data";
                errorLabel.Visible = true;
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

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new employeeInterface();
            newframe.Show();
            Visible = false;
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

        private void newName_TextChanged(object sender, EventArgs e)
        {
            newName.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (newName.Text == "")
            {
                errorLabel.Text = "Please enter your name";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }



        }

        private void customerAddress_TextChanged(object sender, EventArgs e)
        {
            customerAddress.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerAddress.Text == "")
            {
                errorLabel.Text = "Please enter your address";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }
        public static bool CheckPhone(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < '0' || phone[i] > '9')
                {
                    return false;
                }
            }
            if (phone.Length != 11)
            {
                return false;
            }
            return true;
        }

        private void customerPhone_TextChanged(object sender, EventArgs e)
        {
            customerPhone.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerPhone.Text == "")
            {
                errorLabel.Text = "Please enter your phone number";
                errorLabel.Visible = true;
            }
          

            else
            {
                bool check = false;
                for (int i = 0; i < customerPhone.Text.Length; i++)
                {
                    if (customerPhone.Text[i] < '0' || customerPhone.Text[i] > '9')
                    {
                        check = true;
                        break;
                    }
                }
                if (customerPhone.Text.Length != 11 || check)
                {
                    errorLabel.Text = "Please enter a valid phone number";
                    errorLabel.Visible = true;
                }
                else
                {
                    errorLabel.Visible = false;
                }
            }

        }
    }
}
