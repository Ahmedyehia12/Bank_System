using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Bank_System
{
    class Program
    {
        //main
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World!");

            var datasource = @"localhost";//your server
            var database = "BankAPP"; //your database name
            var username = "SA"; //username of server to connect
            var password = "igpvmk123"; //password

            //your connection string

            string connectionString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection opened!");

            AddCustomer(connection);

            AddBankBranch(connection);

            AddCustomerToBranch(connection);

            connection.Close();
            Console.WriteLine("Connection closed!");

            Console.ReadLine();
        }

        static void AddCustomer(SqlConnection connection)
        {
            Console.WriteLine("*** Add a customer(by employee) ***");

            // Get customer details from user as a input

            Console.WriteLine("Enter customer SSN:");
            string ssn = Console.ReadLine();

            Console.WriteLine("Enter customer branch#:");
            string branchNum = Console.ReadLine();

            Console.WriteLine("Enter customer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter customer phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter customer address:");
            string address = Console.ReadLine();

            // Insert customer into the database

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO CUSTOMER (SSN, BRANCH_NUM, CUSTOMER_NAME, CUSTOMER_PHONE, CUSTOMER_ADDRESS) VALUES (@SSN, @BRANCH_NUM, @CUSTOMER_NAME, @CUSTOMER_PHONE, @CUSTOMER_ADDRESS)";
            command.Parameters.AddWithValue("@SSN", ssn);
            command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
            command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
            command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
            command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);

            command.ExecuteNonQuery();

            Console.WriteLine("Customer added successfully!");
            Console.WriteLine("--------------------");
        }

        static void AddBankBranch(SqlConnection connection)
        {
            Console.WriteLine("*** Add bank branch(by admin) ***");

            // Get bank branch details from user as a input

            Console.WriteLine("Enter bank name:");
            string bankName = Console.ReadLine();

            Console.WriteLine("Enter bank code:");
            string bankCode = Console.ReadLine();

            Console.WriteLine("Enter bank address:");
            string bankAddress = Console.ReadLine();

            Console.WriteLine("Enter branch number:");
            int branchNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter branch address:");
            string branchAddress = Console.ReadLine();

            // Insert bank into the database

            SqlCommand bank_command = connection.CreateCommand();
            bank_command.CommandText = "INSERT INTO BANK (BANK_NAME, BANK_CODE, BANK_ADDRESS) " +
                "VALUES (@BANK_NAME, @BANK_CODE, @BANK_ADDRESS)";
            bank_command.Parameters.AddWithValue("@BANK_NAME", bankName);
            bank_command.Parameters.AddWithValue("@BANK_CODE", bankCode);
            bank_command.Parameters.AddWithValue("@BANK_ADDRESS", bankAddress);

            bank_command.ExecuteNonQuery();

            // Insert branch into the database

            SqlCommand branch_command = connection.CreateCommand();
            branch_command.CommandText = "INSERT INTO BRANCH (BANK_CODE, BRANCH_NUM, BRANCH_ADDRESS) " +
                "VALUES (@BANK_CODE, @BRANCH_NUM, @BRANCH_ADDRESS)";
            branch_command.Parameters.AddWithValue("@BANK_CODE", bankCode);
            branch_command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
            branch_command.Parameters.AddWithValue("@BRANCH_ADDRESS", branchAddress);

            branch_command.ExecuteNonQuery();

            Console.WriteLine("Bank branch added successfully!");
            Console.WriteLine("--------------------");
        }

        static void AddCustomerToBranch(SqlConnection connection)
        {
            Console.WriteLine("*** Add Customer to Branch ***");

            // Get customer SSN from user as a input

            Console.WriteLine("Enter customer SSN:");
            string ssn = Console.ReadLine();

            // Get branch number from user as a input

            Console.WriteLine("Enter branch number:");
            int branchNum = Convert.ToInt32(Console.ReadLine());

            // Insert into the database

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO SERVES (SSN, BRANCH_NUM) VALUES (@SSN, @BRANCH_NUM)";
            command.Parameters.AddWithValue("@SSN", ssn);
            command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);

            command.ExecuteNonQuery();

            Console.WriteLine("Customer added to branch successfully!");
            Console.WriteLine("--------------------");
        }
    }
}
   