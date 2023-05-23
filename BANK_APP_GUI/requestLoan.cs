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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BANK_APP_GUI
{
    public partial class requestLoan : Form
    {
        public int ssn;
        public requestLoan(int ssn)
        {
            InitializeComponent();
            this.ssn = ssn;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }


        private void requestLoan_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            string query = "SELECT BRANCH.BRANCH_NUM , BANK.BANK_NAME FROM SERVES , BRANCH , BANK WHERE SERVES.SSN =" + ssn + "and  SERVES.BRANCH_NUM = BRANCH.BRANCH_NUM and BRANCH.BANK_CODE = BANK.BANK_CODE";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Branch Number";
            dataGridView1.Columns[1].HeaderText = "Bank NAME";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;

            string query2 = "SELECT ACCOUNT.ACCOUNT_NUM , ACCOUNT.ACC_TYPE , ACCOUNT.BALANCE FROM ACCOUNT  WHERE ACCOUNT.SSN =" + ssn;
            SqlDataAdapter da2 = new SqlDataAdapter(query2, connectionString);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            dataGridView2.Columns[0].HeaderText = "Account Number";
            dataGridView2.Columns[1].HeaderText = "Account Type";
            dataGridView2.Columns[2].HeaderText = "Balance";
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 200;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerBranch.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerBranch.Text == "")
            {
                errorLabel.Text = "Please enter your Branch Number";
                errorLabel.Visible = true;
            }
            else
            {
                if (!checkCustomerBranch(ssn, customerBranch.Text))
                {
                    errorLabel.Text = "Please enter a valid Branch Number";
                    errorLabel.Visible = true;
                }
                else
                {
                    errorLabel.Visible = false;
                }

            }


        }
        public bool isAllFilled()
        {
            if (customerBranch.Text == "" || customerAccount.Text == "" || amount.Text == "" || loanType.Text == "" ||!checkCustomerAccount(ssn , customerAccount.Text) || !checkCustomerBranch(ssn ,customerBranch.Text))
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
            if (errorLabel.Visible == false && isAllFilled() && checkCustomerAccount(ssn , customerAccount.Text) && checkCustomerBranch(ssn , customerBranch.Text))
            {
                int emp_id = getEmployeeId();
                int loan_num = getLoanum();
                int branch_num = int.Parse(customerBranch.Text);
                int account_num = int.Parse(customerAccount.Text);
                int Amount = int.Parse(amount.Text);
                string loan_type = loanType.Text;
                insertLoan(loan_num, ssn, branch_num, account_num, emp_id, loan_type, Amount, "PENDING");
                if (!loanDecision(account_num, loan_num))
                {
                    MessageBox.Show("Your loan request has been rejected");
                    return;
                }
                MessageBox.Show("Your loan request has been accepted");
                customerInterface Customer = new customerInterface(ssn);
                Customer.Show();
                this.Hide();
            }
            else
            {
                errorLabel.Text = "Please fill all the fields & make sure account num and branch num are correct";
                errorLabel.Visible = true;

            }
        }
        public static void insertLoan(int loan_num, int ssn, int branch_num, int account_num, int emp_id, string loan_type, int Amount, string state)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO LOAN VALUES (" + loan_num + "," + ssn + "," + branch_num + "," + account_num + "," + emp_id + ",'" + loan_type + "'," + Amount + ",'" + state + "')";
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static bool loanDecision(int accountNumber, int loanNum)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM LOAN";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (loanNum == (int)reader["LOAN_NUM"])
                {
                    int amount = (int)reader["LOAN_AMOUNT"];
                    float balance = getBalance(accountNumber);
                    if (amount <= balance * 5)
                    {
                        balance = amount;
                        updateLoanState(loanNum, "Accepted");
                        updateBalanceLoan(balance, accountNumber);
                        return true;
                    }
                    else
                    {
                        updateLoanState(loanNum, "Rejected");
                        return false;
                    }
                }
            }
            reader.Close();
            return false;
            connection.Close();
        }
        public static void updateBalanceLoan(float balance, int accNum)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE ACCOUNT SET BALANCE = @new_balance WHERE ACCOUNT_NUM = @acc_num";
            command.Parameters.AddWithValue("@new_balance", balance);
            command.Parameters.AddWithValue("@acc_num", accNum);
            command.ExecuteReader();
            connection.Close();
        }
        public static void updateLoanState(int loanNum, string decision)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE LOAN SET LOAN_STATE = @new_state WHERE LOAN_NUM = @loan_num";
            command.Parameters.AddWithValue("@new_state", decision);
            command.Parameters.AddWithValue("@loan_num", loanNum);
            command.ExecuteReader();
            connection.Close();

        }

        public static int getBalance(int accountNum)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM ACCOUNT";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (accountNum == (int)reader["ACCOUNT_NUM"])
                {
                    return (int)reader["BALANCE"];
                }
            }
            connection.Close();
            return 0;
        }
        public static bool checkCustomerBranch(int ssn, string bnum)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM SERVES WHERE SERVES.SSN = @ssn and SERVES.BRANCH_NUM = @bnum";
            command.Parameters.AddWithValue("@ssn", ssn);
            command.Parameters.AddWithValue("@bnum", bnum);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;

        }
        public static bool checkCustomerAccount(int ssn, string accNum)
        {
            bool check = false;
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM ACCOUNT WHERE SSN = @ssn AND ACCOUNT_NUM = @accNum";
            command.Parameters.AddWithValue("@ssn", ssn);
            command.Parameters.AddWithValue("@accNum", accNum);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                check = true;
            }
            connection.Close();
            return check;

        }
        public static int getLoanum()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM LOAN";
            SqlDataReader reader = command.ExecuteReader();
            List<int> loanNums = new List<int>();
            while (reader.Read())
            {
                loanNums.Add(int.Parse(reader["LOAN_NUM"].ToString()));
            }

            if (loanNums.Count == 0)
            {
                return 1;
            }

            int max = loanNums.Max();
            return max + 1;

        }
        public static int getEmployeeId()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM EMPLOYEE";
            SqlDataReader reader = command.ExecuteReader();
            List<int> ids = new List<int>();
            while (reader.Read())
            {
                ids.Add(int.Parse(reader["EMP_ID"].ToString()));
            }
            Random random = new Random();
            int index = random.Next(ids.Count);
            return ids[index];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using our App!");
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new customerSignin();
            newframe.Show();
            Visible = false;
        }

        private void customerAccount_TextChanged(object sender, EventArgs e)
        {
            customerAccount.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (customerAccount.Text == "")
            {
                errorLabel.Text = "Please enter your account number";
                errorLabel.Visible = true;
            }
            else
            {
                if (!checkCustomerAccount(ssn, customerAccount.Text))
                {
                    errorLabel.Text = "Please enter a valid account number";
                    errorLabel.Visible = true;
                }
                else
                {
                    errorLabel.Visible = false;
                }
            }
        }

        private void loanType_TextChanged(object sender, EventArgs e)
        {
            loanType.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (loanType.Text == "")
            {
                errorLabel.Text = "Please enter your loan type";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            amount.Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (amount.Text == "")
            {
                errorLabel.Text = "Please enter your loan amount";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }

        }
    }
}
