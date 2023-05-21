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
            if (errorLabel.Visible == false)
            {
                string ID = ID_textbox.Text;
                employeeInterface employee_interface = new employeeInterface();
                employee_interface.Show();
                this.Hide();
            }




        }

        private void ID_textbox_TextChanged(object sender, EventArgs e)
        {
            ID_textbox.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (ID_textbox.Text == "")
            {
                errorLabel.Text = "Please enter your ID";
                errorLabel.Visible = true;
            }
            else
            {
                if (checkId(ID_textbox.Text) == false)
                {
                    errorLabel.Text = "ID not found";
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
            this.Hide();
        }
        public static bool checkId(string id)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM EMPLOYEE";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["EMP_ID"].ToString() == id.ToString())
                {
                    return true;
                }
            }
            return false;

        }

    }
}
