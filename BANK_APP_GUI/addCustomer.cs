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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = customerName.Text;
            string address = customerAddress.Text;
            string phone = customerPhone.Text;
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            int maxSSN = GetMaxSSN(connection);
            while (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please Enter a Valid Phone Number");
                phone = customerPhone.Text;
            }
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
    }
}
