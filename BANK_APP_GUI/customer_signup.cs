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
            while (phone.Length != 11)
            {
                MessageBox.Show("Invalid Phone Number");
                phone = this.phone.Text;
            }
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand commandSSN = connection.CreateCommand();
            commandSSN.CommandText = "SELECT * FROM CUSTOMER";
            SqlDataReader reader = commandSSN.ExecuteReader();
            int SSN = 0;

            while (reader.Read())
            {
                SSN = (int)reader["SSN"];
            }
            SSN++;
            connection.Close();

            SqlConnection connection2 = new SqlConnection(connectionString);
            connection2.Open();
            SqlCommand command = connection2.CreateCommand();
            command.CommandText = "INSERT INTO CUSTOMER VALUES(@SSN, @CUSTOMER_NAME, @CUSTOMER_ADDRESS, @CUSTOMER_PHONE)";
            command.Parameters.AddWithValue("@SSN", SSN);
            command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
            command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);
            command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
            command.ExecuteNonQuery();
            connection.Close();


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
        public int getAccountNum()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM ACCOUNT";
            SqlDataReader reader = command.ExecuteReader();
            int accountNum = 0;
            while (reader.Read())
            {
                accountNum = (int)reader["ACCOUNT_NUM"];
            }
            accountNum++;
            connection.Close();
            return accountNum;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = this.name.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string address = this.address.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string phone = this.phone.Text;
            if (phone.Length != 11)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new sign_up();
            newframe.Show();
            Visible = false;
        }
    }
}
