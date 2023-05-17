
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {

            ////your connection string 
            //string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BankSystem ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";

            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //SqlCommand command = connection.CreateCommand();
            //command.CommandText = "SELECT * FROM BANK";
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["BANK_CODE"] + " " + reader["BANK_ADDRESS"] + " " + reader["BANK_NAME"]);
            //}
            //Console.ReadLine();
            //connection.Close();

            Console.WriteLine("Welcome to our Bank System Application! \n\nPlease specify your choice: \n1. Sign in. \n2. Sign up.\n");
            int choice = int.Parse(Console.ReadLine());

            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Invalid choice, please enter a valid choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                signIn();
            }
            else if (choice == 2)
            {
                signUp();
            }
            else
            {

            }

            static void signIn()
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
                }
                else if (choice == 2)
                {
                }
                else
                {

                }
            }

            static void signUp()
            {
                Console.WriteLine("Signing up as?");
                Console.WriteLine("1- Customer");
                Console.WriteLine("2- Employee");
                int choice = int.Parse(Console.ReadLine());
                while (choice != 1 && choice != 2)
                {
                    Console.WriteLine("Invalid choice, please enter a valid choice: ");
                    choice = int.Parse(Console.ReadLine());
                }
                if (choice == 1)
                {
                    customerSignUp();
                }
                else
                {
                    employeeSignUp();
                }
            }

            static void customerSignUp()
            {

                Console.WriteLine("Enter the branch number: ");
                int branchNum = int.Parse(Console.ReadLine());
                while (!checkBranchNum(branchNum))
                {
                    Console.WriteLine("This branch number is not found in the database, please enter a valid branch number: ");
                    branchNum = int.Parse(Console.ReadLine());
                }

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

                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BankSystem ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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
                command.CommandText = "INSERT INTO CUSTOMER VALUES(@SSN, @BRANCH_NUM, @CUSTOMER_NAME, @CUSTOMER_ADDRESS, @CUSTOMER_PHONE)";
                command.Parameters.AddWithValue("@SSN", SSN);
                command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
                command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
                command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);
                command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
                command.ExecuteNonQuery();
                Console.WriteLine("Customer has been added successfully, your ID is " + SSN);

                connection2.Close();
            }

            static void employeeSignUp()
            {
                Console.WriteLine("Enter the branch number: ");
                int branchNum = int.Parse(Console.ReadLine());
                while (!checkBranchNum(branchNum))
                {
                    Console.WriteLine("This branch number is not found in the database, please enter a valid branch number: ");
                    branchNum = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your Address: ");
                string address = Console.ReadLine();

                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BankSystem ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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
                command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
                command.Parameters.AddWithValue("@EMPLOYEE_NAME", name);
                command.Parameters.AddWithValue("@EMPLOYEE_ADDRESS", address);
                command.ExecuteNonQuery();
                Console.WriteLine("Employee has been added successfully, your ID is " + EMP_ID);

                connection2.Close();
            }

            static bool checkBranchNum(int bnum)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BankSystem ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static bool checkPhoneNumber(string phone)
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

        }
    }
}