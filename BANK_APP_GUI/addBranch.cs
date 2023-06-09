﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BANK_APP_GUI
{
    public partial class addBranch : Form
    {
        private string branchAddress;
        private int bankCode;
        public addBranch()
        {
            InitializeComponent();
        }

        private void addBranch_Load(object sender, EventArgs e)
        {

        }
        public bool checkBankCode(string code)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT BANK_CODE FROM BANK WHERE BANK_CODE = @bank_code";
            command.Parameters.AddWithValue("@bank_code", code);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return true;
            }
            else
            {
                reader.Close();
                connection.Close();
                return false;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (textBox2.Text == "")
            {
                errorLabel.Text = "Please Enter Branch Address";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }
        public bool isAllFilled()
        {
            if (textBox2.Text == "" || numericUpDown1.Value == 0 || !checkBankCode(numericUpDown1.Value.ToString()))
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
            if (errorLabel.Visible == false && isAllFilled() && checkBankCode(numericUpDown1.Value.ToString()))
            {
                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                SqlConnection connection = new SqlConnection(connectionString);

                int branchNum = getBranchNum();
                int bankCode = Convert.ToInt32(numericUpDown1.Value);
                string branchAddress = textBox2.Text;

                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO BRANCH (BANK_CODE, BRANCH_NUM, BRANCH_ADDRESS) " +
                    "VALUES (@BANK_CODE, @BRANCH_NUM, @BRANCH_ADDRESS)";
                command.Parameters.AddWithValue("@BANK_CODE", bankCode);
                command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
                command.Parameters.AddWithValue("@BRANCH_ADDRESS", branchAddress);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Branch Added Successfully!");
            }
            else
            {
                errorLabel.Text = "Please Fill All Fields Accurately & Check Bank Code";
                errorLabel.Visible = true;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new admin_interface();
            newframe.Show();
            Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!checkBankCode(numericUpDown1.Value.ToString()))
            {
                errorLabel.Text = "Bank Code Doesn't Exist";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }

        public static int getBranchNum()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int branchNum = 0;
            SqlCommand commandSSN = connection.CreateCommand();
            commandSSN.CommandText = "SELECT MAX(BRANCH_NUM) AS MaxNum FROM BRANCH";
            SqlDataReader reader = commandSSN.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MaxNum")))
                {
                    branchNum = (int)reader["MaxNum"];
                }
            }

            reader.Close();
            connection.Close();

            return branchNum + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using our App!");
            Close();
        }
    }
}
