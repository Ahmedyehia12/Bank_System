using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_APP_GUI
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }
        public bool isAllFilled()
        {
            if (customerName.Text == "" || customerAddress.Text == "" || customerPhone.Text == "")
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
            if (errorLabel.Visible == false && isAllFilled())
            {
                string name = customerName.Text;
                string address = customerAddress.Text;
                string phone = customerPhone.Text;
                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                SqlConnection connection = new SqlConnection(connectionString);
                int maxSSN = GetMaxSSN(connection);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO CUSTOMER (SSN, CUSTOMER_NAME, CUSTOMER_PHONE, CUSTOMER_ADDRESS) VALUES (@SSN, @CUSTOMER_NAME, @CUSTOMER_PHONE, @CUSTOMER_ADDRESS)";
                command.Parameters.AddWithValue("@SSN", maxSSN);
                command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
                command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
                command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer Added Successfully");
                employeeInterface employee = new employeeInterface();
                employee.Show();
                this.Hide();
            
           }
            else
            {
                errorLabel.Text = "Please fill all the fields";
                errorLabel.Visible = true;

            }
        }
        public static int GetMaxSSN(SqlConnection connection)
        {
            int maxSSN = 0;
            connection.Open();
            SqlCommand commandSSN = connection.CreateCommand();
            commandSSN.CommandText = "SELECT MAX(SSN) AS MaxSSN FROM CUSTOMER";
            SqlDataReader reader = commandSSN.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MaxSSN")))
                {
                    maxSSN = (int)reader["MaxSSN"];
                }
            }

            reader.Close();
            connection.Close();

            return maxSSN + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new employeeInterface();
            newframe.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using our App!");
            Close();
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            customerName.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerName.Text == "")
            {
                errorLabel.Text = "Please enter your Name";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }
        }

        private void customerPhone_TextChanged(object sender, EventArgs e)
        {
            customerPhone.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerPhone.Text == "")
            {
                errorLabel.Text = "Please enter your Phone Number";
                errorLabel.Visible = true;
            }
            else
            {
                bool check = false;
                for(int i = 0; i < customerPhone.Text.Length; i++)
                {
                    if (customerPhone.Text[i] < '0' || customerPhone.Text[i] > '9')
                    {
                        check = true;
                        break;
                    }
                }
                if (customerPhone.Text.Length != 11 || check)
                {
                    errorLabel.Text = "Please enter a valid Phone Number";
                    errorLabel.Visible = true;
                }
                else
                {
                    errorLabel.Visible = false;
                }

            }

        }

        private void customerAddress_TextChanged(object sender, EventArgs e)
        {
            customerAddress.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerAddress.Text == "")
            {
                errorLabel.Text = "Please enter your Address";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }
    }
}
