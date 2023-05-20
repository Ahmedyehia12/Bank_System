using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;
using System.Net;

namespace Bank_System
{
    public partial class Employee
    {
       public static void employeeInterface()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            Console.WriteLine("Enter your id:");
            int id = int.Parse(Console.ReadLine());
            while (!checkId(id))
            {
                Console.WriteLine("This id is not found in the database, please enter a valid id: ");
                id = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Welcome to our bank, what do you want to do?");
            Console.WriteLine("1- Add a new Customer");
            Console.WriteLine("2- Update a Customer's data");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice, please enter a valid choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                AddCustomer(connection);
            }
            else
            {
                UpdateCustomerData();
                DisplayCustomers();
            }
        }
        public static void UpdateCustomerData()
        {
            Console.WriteLine("Enter the customer's SSN: ");
            int ssn = int.Parse(Console.ReadLine());
            while (!Customer.CheckSSN(ssn))
            {
                Console.WriteLine("This SSN is not found in the database, please enter a valid SSN: ");
                ssn = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Enter customer's new name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter customer's new address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter customer's new phone number:");
            string phone = Console.ReadLine();
            if (phone.Length != 11)
            {
                Console.WriteLine("Invalid phone number, please enter a valid phone number:");
                phone = Console.ReadLine();
            }
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE CUSTOMER SET  CUSTOMER_NAME = @name, CUSTOMER_ADDRESS = @address, CUSTOMER_PHONE = @phone WHERE SSN = @ssn";
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@ssn", ssn);

            command.ExecuteNonQuery();
            Console.WriteLine("Customer's data has been updated successfully");
            connection.Close();
        }

        public static bool checkBranchNum(int bnum)
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
        public static void employeeSignUp()
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
            command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
            command.Parameters.AddWithValue("@EMPLOYEE_NAME", name);
            command.Parameters.AddWithValue("@EMPLOYEE_ADDRESS", address);
            command.ExecuteNonQuery();
            Console.WriteLine("Employee has been added successfully, your ID is " + EMP_ID);

            connection2.Close();
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
        public static void AddCustomer(SqlConnection connection)
        {
            Console.WriteLine("*** Add a customer(by employee) ***");

            // Get customer details from user as a input

            Console.WriteLine("Enter customer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter customer phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter customer address:");
            string address = Console.ReadLine();

            // Insert customer into the database
            int ssn = GetMaxSSN(connection);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO CUSTOMER (SSN, CUSTOMER_NAME, CUSTOMER_PHONE, CUSTOMER_ADDRESS) VALUES (@SSN, @CUSTOMER_NAME, @CUSTOMER_PHONE, @CUSTOMER_ADDRESS)";
            command.Parameters.AddWithValue("@SSN", ssn);
            command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
            command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
            command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);

            command.ExecuteNonQuery();

            Console.WriteLine("Customer added successfully!");
            Console.WriteLine("--------------------");
            connection.Close();
        }
        public static void DisplayCustomers()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM CUSTOMER";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("SSN: " + reader["SSN"].ToString());
                Console.WriteLine("Name: " + reader["CUSTOMER_NAME"].ToString());
                Console.WriteLine("Address: " + reader["CUSTOMER_ADDRESS"].ToString());
                Console.WriteLine("Phone: " + reader["CUSTOMER_PHONE"].ToString());
                Console.WriteLine("--------------------------------------------------");
            }
            reader.Close();
            connection.Close();
        }
        public static bool checkId(int id)
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