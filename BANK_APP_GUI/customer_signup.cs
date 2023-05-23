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
using System.Data.SqlClient;
using System.Security.AccessControl;

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
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (errorLabel.Visible == false && isAllFilled() &&  checkPhoneNum(phone.Text))
            {
                string name = this.name.Text;
                string address = this.address.Text;
                string accountType;

                if (radioButton1.Checked)
                {
                    accountType = "Savings";
                }
                else if (radioButton2.Checked)
                {
                    accountType = "Fixed Deposit";
                }
                else
                {
                    accountType = "Salary";
                }
                string phone = this.phone.Text;

                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                 

                SqlConnection connection2 = new SqlConnection(connectionString);
                connection2.Open();
                SqlCommand command = connection2.CreateCommand();
                int SSN = getMaxSSN();
                command.CommandText = "INSERT INTO CUSTOMER VALUES(@SSN, @CUSTOMER_NAME, @CUSTOMER_ADDRESS, @CUSTOMER_PHONE)";
                command.Parameters.AddWithValue("@SSN", SSN);
                command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
                command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);
                command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
                command.ExecuteNonQuery();
                connection2.Close();


                int accountNum = getAccountNum();
                int balance = 0;
                SqlConnection connection4 = new SqlConnection(connectionString);
                connection4.Open();
                SqlCommand command2 = connection4.CreateCommand();
                command2.CommandText = "INSERT INTO ACCOUNT VALUES(@ACCOUNT_NUM, @SSN, @BALANCE, @ACCOUNT_TYPE)";
                command2.Parameters.AddWithValue("@ACCOUNT_NUM", accountNum);
                command2.Parameters.AddWithValue("@SSN", SSN);
                command2.Parameters.AddWithValue("@BALANCE", 0.0);
                command2.Parameters.AddWithValue("@ACCOUNT_TYPE", accountType);
                command2.ExecuteNonQuery();
                connection4.Close();
                MessageBox.Show("Information saved\tCustomer signed-up Successfully");
            }
            else
            {


                errorLabel.Text = "Please fill all the required fields Accurately & check any Invalid Data";
                errorLabel.Visible = true;
                
                
            }
        }
      
        public int getMaxSSN()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT MAX(SSN) FROM CUSTOMER";
            SqlDataReader reader = command.ExecuteReader();
            int ssn = 0;
            if(reader.Read())
            {
                ssn = (int)reader[0];
            }
            ssn++;
            connection.Close();
            return ssn;
        }
        public int getAccountNum()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText  = "SELECT MAX(ACCOUNT_NUM) FROM ACCOUNT";
            SqlDataReader reader = command.ExecuteReader();
            int accountNum = 0;
            if(reader.Read())
            {
                accountNum = (int)reader[0];
            }   
            accountNum++;
            connection.Close();
            return accountNum;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (name.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "name is required";
            }
            else
            {
                errorLabel.Visible = false;
            }

        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            address.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (address.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Address is Required";
            }
            else
            {
                errorLabel.Visible = false;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            phone.Text = ((System.Windows.Forms.TextBox)sender).Text;

            if (phone.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Please enter your phone number";
            }
            else
            {
                if (checkPhoneNum(phone.Text) == false)
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Please enter a valid phone number";
                }
                else
                {
                    errorLabel.Visible = false;
                }
            }


        }
        public bool checkPhoneNum(string num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] < '0' || num[i] > '9')
                {
                    return false;
                }
            }
            if (num.Length != 11)
            {
                return false;
            }
            return true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new sign_up();
            newframe.Show();
            Visible = false;
        }
        public bool isAllFilled()
        {
            if (name.Text == "" || address.Text == "" || phone.Text == "")
            {
                return false;
            }
            return true;

        }

        private void customer_signup_Load(object sender, EventArgs e)
        {
       

        }
    }
}
