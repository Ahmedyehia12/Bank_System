
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Signing in as?");
            Console.WriteLine("1- Customer");
            Console.WriteLine("2- Employee");
            Console.WriteLine("3- Admin");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Invalid choice, please enter a valid choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                customer_interface();
            }
            else if (choice == 2)
            {
                employeeInterface();
            }
            else
            {
                adminInterface();

            }

            static void customer_interface()
            {
                String connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Enter your SSN: ");
                int ssn = int.Parse(Console.ReadLine());
                while (!CheckSSN(ssn))
                {
                    Console.WriteLine("This SSN is not found in the database, please enter a valid SSN: ");
                    ssn = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Welcome to our bank, what do you want to do?");
                Console.WriteLine("1- Open a new account");
                Console.WriteLine("2-apply for a loan");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    //penAccount(ssn);
                }
                else if (choice == 2)
                {
                    requestLoan(ssn);
                }
               
               
 
                connection.Close();


            }


            static bool checkLoanNum(int num)
            {
                string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM LOAN";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["LOAN_NUM"].ToString() == num.ToString())
                    {
                        return false;
                    }
                }
                return true;
            }
            static void requestLoan(int ssn)
            {
                Console.WriteLine("Enter Loan number: ");
                int loanNum = int.Parse(Console.ReadLine());
                while(!checkLoanNum(loanNum))
                {
                    Console.WriteLine("This loan number is already taken, please enter a valid loan number: ");
                    loanNum = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the branch number: ");
                int branchNum = int.Parse(Console.ReadLine());
                while (!checkBranchNum(branchNum))
                {
                    Console.WriteLine("This branch number is not found in the database, please enter a valid branch number: ");
                    branchNum = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the amount of money you want to loan: ");
                int amount = int.Parse(Console.ReadLine());
                // employee id
                Console.WriteLine("Enter the Assigned Employee's ID: ");
                int empId = int.Parse(Console.ReadLine());
                while (!checkId(empId))
                {
                    Console.WriteLine("This id is not found in the database, please enter a valid id: ");
                    empId = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the loan type: ");
                string type = Console.ReadLine();
                string state = "pending";
                string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO LOAN VALUES(@LOAN_NUM, @SSN, @BRANCH_NUM, @EMP_ID,@LOAN_TYPE, @LOAN_AMOUNT, @LOAN_STATE)";
                command.Parameters.AddWithValue("@LOAN_NUM", loanNum);
                command.Parameters.AddWithValue("@SSN", ssn);
                command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
                command.Parameters.AddWithValue("@EMP_ID", empId);
                command.Parameters.AddWithValue("@LOAN_TYPE", type);
                command.Parameters.AddWithValue("@LOAN_AMOUNT", amount);
                command.Parameters.AddWithValue("@LOAN_STATE", state);
                command.ExecuteNonQuery();
                Console.WriteLine("Your loan request has been sent successfully");
                connection.Close();

         



   }
            static bool checkId(int id)
            {
                string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
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
            static void employeeInterface()
            {
                Console.WriteLine("enter your id :");
                int id = int.Parse(Console.ReadLine());
                while (!checkId(id))
                {
                    Console.WriteLine("This id is not found in the database, please enter a valid id: ");
                    id = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Welcome to our bank, what do you want to do?");
                Console.WriteLine("1- Add a new Customer");
                Console.WriteLine("2- Update a Customer's data");
                Console.WriteLine("3-perform operations on loans");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 2)
                {
                    UpdateCustomerData();
                    DisplayCustomers();
                }
            }
            static void adminInterface()
            {
                Console.WriteLine("Welcome to our bank, what do you want to do?");
                Console.WriteLine("1- Add a new Bank");
                Console.WriteLine("2- Add a new Branch");
            }

            static void DisplayCustomers()
            {
                string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM CUSTOMER";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("SSN: " + reader["SSN"].ToString());
                    Console.WriteLine("Branch number: " + reader["BRANCH_NUM"].ToString());
                    Console.WriteLine("Name: " + reader["CUSTOMER_NAME"].ToString());
                    Console.WriteLine("Address: " + reader["CUSTOMER_ADDRESS"].ToString());
                    Console.WriteLine("Phone: " + reader["CUSTOMER_PHONE"].ToString());
                    Console.WriteLine("--------------------------------------------------");
                }
                reader.Close();
                connection.Close();
            }
            static bool CheckSSN(int ssn)
            {
                string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
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
           static bool checkBranchNum(int bnum)
            {
                string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM BRANCH";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["BRANCH_NUM"].ToString() == bnum.ToString())
                    {
                        return true;
                    }
                }
                return false;
            }
            static void UpdateCustomerData()
            {
                Console.WriteLine("Enter the customer's SSN: ");
                int ssn = int.Parse(Console.ReadLine());
                while (!CheckSSN(ssn))
                {
                    Console.WriteLine("This SSN is not found in the database, please enter a valid SSN: ");
                    ssn = int.Parse(Console.ReadLine());

                } 
             Console.WriteLine("Enter the customer's new Branch number , if you dont want to change his current branch just enter the same number: ");
                string branchNum = Console.ReadLine();
                while (!checkBranchNum(int.Parse(branchNum)))
                {
                    Console.WriteLine("This branch number is not found in the database, please enter a valid branch number: ");
                    branchNum = Console.ReadLine();
                }
                Console.WriteLine("Enter customer's new name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter customer's new address:");
                string address = Console.ReadLine();
                Console.WriteLine("Enter customer's new phone number:");
                string phone = Console.ReadLine();
                if(phone.Length != 11)
                {
                    Console.WriteLine("Invalid phone number, please enter a valid phone number:");
                    phone = Console.ReadLine();
                }
                string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM_DB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE CUSTOMER SET BRANCH_NUM = @branchNum, CUSTOMER_NAME = @name, CUSTOMER_ADDRESS = @address, CUSTOMER_PHONE = @phone WHERE SSN = @ssn";
                command.Parameters.AddWithValue("@branchNum", branchNum);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@ssn", ssn);
                command.ExecuteNonQuery();
                Console.WriteLine("Customer's data has been updated successfully");
                connection.Close();

          
            }

        }
    }
}
