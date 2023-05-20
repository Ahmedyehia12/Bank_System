using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
namespace BANK_APP_GUI
{
    public partial class employee_signin : Form
    {
        public employee_signin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ID_textbox.Text);
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM EMPLOYEE";
            SqlDataReader reader = command.ExecuteReader();
            bool check = false;
            while (reader.Read())
            {
                if (reader["EMP_ID"].ToString() == ID.ToString())
                {
                    check = true;
                }
            }
            if (check == true)
            {
                employeeInterface employee_interface = new employeeInterface();
                employee_interface.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID");
            }


        }

        private void ID_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}