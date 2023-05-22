using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace BANK_APP_GUI
{
    public partial class addBank : Form
    {
        private string bankName;
        private string bankAddress;
        private int bankCode;
        public addBank()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (errorLabel.Visible == false)
            {
                int bank_code = GetMaxBankCode();
                string bankName = textBox1.Text;
                string bankAddress = textBox2.Text;
                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO BANK (BANK_CODE, BANK_NAME, BANK_ADDRESS) VALUES (@bank_code, @bank_name, @bank_address)";
                command.Parameters.AddWithValue("@bank_code", bank_code);
                command.Parameters.AddWithValue("@bank_name", bankName);
                command.Parameters.AddWithValue("@bank_address", bankAddress);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Bank Added Successfully");

            }





        }
     

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new admin_interface();
            newframe.Show();
            Visible = false;
        }

        private void addBank_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (textBox1.Text == "")
            {
                errorLabel.Text = "Please Enter Bank Name";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (textBox2.Text == "")
            {
                errorLabel.Text = "Please Enter Bank Address";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }

        private static int GetMaxBankCode()
        {
            int maxBankCode = 0;
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand commandBankCode = connection.CreateCommand();
            commandBankCode.CommandText = "SELECT MAX(BANK_CODE) AS MaxBankCode FROM BANK";
            SqlDataReader reader = commandBankCode.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MaxBankCode")))
                {
                    maxBankCode = (int)reader["MaxBankCode"];
                }
            }

            reader.Close();
            connection.Close();

            return maxBankCode + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using our App!");
            Close();
        }
        public bool isAllFilled()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return false;
            }
            return true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (errorLabel.Visible == false && isAllFilled())
            {
                int bank_code = GetMaxBankCode();
                string bankName = textBox1.Text;
                string bankAddress = textBox2.Text;
                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO BANK (BANK_CODE, BANK_NAME, BANK_ADDRESS) VALUES (@bank_code, @bank_name, @bank_address)";
                command.Parameters.AddWithValue("@bank_code", bank_code);
                command.Parameters.AddWithValue("@bank_name", bankName);
                command.Parameters.AddWithValue("@bank_address", bankAddress);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Bank Added Successfully");

            }
            else
            {
               errorLabel.Text = "Please Fill All Fields";
                errorLabel.Visible = true;


            }

        }
    }
}
