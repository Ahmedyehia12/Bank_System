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
    public partial class employee_signup : Form
    {
        public employee_signup()
        {
            InitializeComponent();
        }
        public static bool checkBranchNum(string bnum)
        {

            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM BRANCH";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["BRANCH_NUM"].ToString() == bnum.ToString())
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }
        public bool isAllFilled()
        {
            if (name.Text == "" || branchNum.Text == "" || Address.Text == "")
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
            if (!errorLabel.Visible && isAllFilled() && checkBranchNum(branchNum.Text))
            {


                string name = this.name.Text;
                string branch = this.branchNum.Text;
                int branch_num = int.Parse(branch);
                string address = this.Address.Text;
                string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand commandSSN = connection.CreateCommand();
                commandSSN.CommandText = "SELECT * FROM EMPLOYEE";
                SqlDataReader reader = commandSSN.ExecuteReader();
                int EMP_ID = 0;

                while (reader.Read())
                {
                    EMP_ID = (int)reader["EMP_ID"];
                }
                EMP_ID++;
                connection.Close();
                SqlConnection connection2 = new SqlConnection(connectionString);
                connection2.Open();
                SqlCommand command = connection2.CreateCommand();
                command.CommandText = "INSERT INTO EMPLOYEE VALUES(@EMP_ID, @BRANCH_NUM, @EMPLOYEE_NAME, @EMPLOYEE_ADDRESS)";
                command.Parameters.AddWithValue("@EMP_ID", EMP_ID);
                command.Parameters.AddWithValue("@BRANCH_NUM", branch_num);
                command.Parameters.AddWithValue("@EMPLOYEE_NAME", name);
                command.Parameters.AddWithValue("@EMPLOYEE_ADDRESS", address);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Information saved\tEmployee signed-up Successfully");
            }
            else
            {
                errorLabel.Text = "Please fill all the required fields & Enter valid Branch Number";
                errorLabel.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new sign_up();
            form.Show();
            Visible = false;

        }

        private void branchNum_TextChanged(object sender, EventArgs e)
        {
            branchNum.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (branchNum.Text == "")
            {
                errorLabel.Text = "Branch Number is required";
                errorLabel.Visible = true;

            }
            else
            {
                if (!checkBranchNum(branchNum.Text))
                {
                    errorLabel.Text = "Invalid Branch Number";
                    errorLabel.Visible = true;

                }
                else
                {
                    errorLabel.Visible = false;
                }
            }







        }

        private void employee_signup_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            name.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (name.Text == "")
            {
                errorLabel.Text = "Name is required";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }


        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            Address.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (Address.Text == "")
            {
                errorLabel.Text = "Address is required";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }
    }
}
