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

        private void button1_Click(object sender, EventArgs e)
        {
            int ssn = Convert.ToInt32(customerSSN.Text);
            while(CheckSSN(ssn) == false)
            {
                MessageBox.Show("Wrong SSN");
                ssn = Convert.ToInt32(customerSSN.Text);
            }
            string name= newName.Text;
            string address = customerAddress.Text;
            string phone = customerPhone.Text;
            while(phone.Length != 11)
            {
                MessageBox.Show("Wrong Phone Number");
                phone = customerPhone.Text;
            }
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
            this.Hide();
          }
        public static bool CheckSSN(int ssn)
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
    }
}
