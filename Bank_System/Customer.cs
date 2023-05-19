using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace Bank_System
{
   public partial class Customer
    {
       public static void customerInterface()
        {

            Console.WriteLine("Enter your SSN: ");
            int ssn = int.Parse(Console.ReadLine());
            while (!CheckSSN(ssn))
            {
                Console.WriteLine("This SSN is not found in the database, please enter a valid SSN: ");
                ssn = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Welcome to our bank, what do you want to do?");
            Console.WriteLine("1- Apply for a loan");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice, please enter a valid choice: ");
                choice = int.Parse(Console.ReadLine());
            }

            requestLoan(ssn);

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
        public static float getBalance(int accountNum)
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
        public static void requestLoan(int ssn)
        {
            Console.WriteLine("Enter Loan type: \n1. Industry Loan.\n2. Commercial Loan. \n3. Personal Loan.");
            int choice = int.Parse(Console.ReadLine());
            string type;
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Invalid choice, please enter a valid choice[1:3]: ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                type = "Industry";
            }
            else if (choice == 2)
            {
                type = "Commercial";

            }
            else
            {
                type = "Personal";
            }

            displayCustomerBranches(ssn);
            Console.WriteLine("Enter the branch number you want to request a loan from: ");
            int branchNum = int.Parse(Console.ReadLine());
            while (!checkCustomerBranch(ssn))
            {
                Console.WriteLine("This branch number is not found in the database, please enter a valid branch number: ");
                branchNum = int.Parse(Console.ReadLine());
            }
            displayCustomerAccounts(ssn);
            Console.WriteLine("Enter Account Number for your loan request:");
            int accountNumber = int.Parse(Console.ReadLine());
            while (!checkCustomerAccount(ssn, accountNumber))
            {
                Console.WriteLine("Invalid account number, please enter a valid one: ");
                accountNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter Loan amount:");
            int amount = int.Parse(Console.ReadLine());
            while (amount <= 1000)
            {
                Console.WriteLine("Invalid loan amount [minimum = 1000], please enter a valid amount: ");
                amount = int.Parse(Console.ReadLine());
            }

            string loan_state = "PENDING";
            int loan_num = getLoanum();
            int empId = getEmployeeId();
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO LOAN(LOAN_NUM,SSN,BRANCH_NUM,ACCOUNT_NUM,EMP_ID,LOAN_TYPE,LOAN_AMOUNT,LOAN_STATE) VALUES(@loan_num,@ssn,@branchNum,@accountNumber,@empID,@type,@amount, @loan_state)";
            command.Parameters.AddWithValue("@loan_num", loan_num);
            command.Parameters.AddWithValue("@ssn", ssn);
            command.Parameters.AddWithValue("@branchNum", branchNum);
            command.Parameters.AddWithValue("@accountNumber", accountNumber);
            command.Parameters.AddWithValue("@empId", empId);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@loan_state", loan_state);

            command.ExecuteNonQuery();
            Console.WriteLine("Loan request sent successfully");
            connection.Close();
            loanDecision(accountNumber, loan_num);
        }
        public static bool checkCustomerAccount(int ssn, int accNum)
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
      public  static bool checkCustomerBranch(int ssn)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM SERVES";
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

       public static void displayCustomerAccounts(int ssn)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM ACCOUNT JOIN CUSTOMER ON ACCOUNT.SSN =CUSTOMER.SSN";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Your accounts: ");
            while (reader.Read())
            {
                if (reader["SSN"].ToString() == ssn.ToString())
                {
                    Console.WriteLine("ACC NUM :" + reader["ACCOUNT_NUM"].ToString() + "   Account Type:" + reader["ACC_TYPE"]);
                }
            }
            connection.Close();


        }

       public static void displayCustomerBranches(int ssn)
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM SERVES , BRANCH WHERE SERVES.SSN = @ssn  AND  SERVES.BRANCH_NUM = BRANCH.BRANCH_NUM AND BRANCH.BANK_CODE = BANK.BANK_CODE";
            command.Parameters.AddWithValue("@ssn", ssn);
            connection.Close();
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Your branches: ");
            while (reader.Read())
            {
                Console.WriteLine("Branch number: " + reader["BRANCH_NUM"].ToString() + "     Bank name:" + reader["BANK_NAME"]);
            }
            reader.Close();
        }

        public static bool checkPhoneNumber(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < '0' || phone[i] > '9')
                {
                    Console.WriteLine("Invalid phone number, it must contain only numbers[0-9], please try again: ");
                    return false;
                }
            }
            while (phone.Length != 11)
            {
                Console.WriteLine("Invalid phone number, it should be 11 digits-long: ");
                return false;

            }
            return true;
        }

        public static void customerSignUp()
        {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter your phone: ");
            string phone = Console.ReadLine();

            while (!checkPhoneNumber(phone))
            {
                phone = Console.ReadLine();
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
            Console.WriteLine("Customer has been added successfully, your ID is " + SSN);

            connection2.Close();

            SqlConnection connection3 = new SqlConnection(connectionString);
            connection3.Open();

            SqlCommand command1 = connection3.CreateCommand();
            command1.CommandText = "SELECT * FROM ACCOUNT";
            SqlDataReader reader2 = command1.ExecuteReader();
            int accountNum = 0;

            while (reader2.Read())
            {
                accountNum = (int)reader["ACCOUNT_NUM"];
            }
            accountNum++;
            connection3.Close();

            string accType;
            Console.WriteLine("Choose your Account Type:");
            Console.WriteLine("1- Saving");
            Console.WriteLine("2- Fixed Deposit");
            Console.WriteLine("3- Salary");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Invalid choice, please enter a valid choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                accType = "Saving";
            }
            else if (choice == 2)
            {
                accType = "Fixed Deposit";
            }
            else
            {
                accType = "Salary";
            }


            SqlConnection connection4 = new SqlConnection(connectionString);
            connection4.Open();

            SqlCommand command2 = connection4.CreateCommand();
            command2.CommandText = "INSERT INTO ACCOUNT VALUES(@ACCOUNT_NUM, @SSN, @BALANCE, @ACCOUNT_TYPE)";
            command2.Parameters.AddWithValue("@ACCOUNT_NUM", accountNum);
            command2.Parameters.AddWithValue("@SSN", SSN);
            command2.Parameters.AddWithValue("@BALANCE", 0.0);
            command2.Parameters.AddWithValue("@ACCOUNT_TYPE", accType);
            command2.ExecuteNonQuery();
            Console.WriteLine("Customer has been added successfully, your ID is " + SSN);
            Console.WriteLine("Your Account ID is " + accountNum);

            connection4.Close();

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
       public  static void loanDecision(int accountNumber, int loanNum)
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
                        Console.WriteLine("Loan is Accepted your new balance = " + balance + " for your account number: " + accountNumber);
                    }
                    else
                    {
                        Console.WriteLine("Loan Rejected!");
                        updateLoanState(loanNum, "Rejected");
                        Console.WriteLine("Loan is rejected, insuffient balance for that loan amount [Minimum balance required is " + balance * 5 + " ]");
                    }
                }
            }
            connection.Close();
        }


    }
}