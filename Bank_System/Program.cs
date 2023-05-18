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

            int maxSSN = GetMaxSSN(connection);
            int maxBankCode = GetMaxBankCode(connection);

            AddCustomer(connection, maxSSN);
            AddBankBranch(connection, maxBankCode);

            connection.Close();
            Console.WriteLine("Connection closed!");

            Console.ReadLine();
        }

        static int GetMaxSSN(SqlConnection connection)
        {
            int maxSSN = 0;

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

            return maxSSN + 1;
        }

        static int GetMaxBankCode(SqlConnection connection)
        {
            int maxBankCode = 0;

            SqlCommand commandBankCode = connection.CreateCommand();
            commandBankCode.CommandText = "SELECT MAX(BANK_CODE) AS MaxBankCode FROM BANK_BRANCH";
            SqlDataReader reader = commandBankCode.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MaxBankCode")))
                {
                    maxBankCode = (int)reader["MaxBankCode"];
                }
            }

            reader.Close();

            return maxBankCode + 1;
        }

        static void AddCustomer(SqlConnection connection, int ssn)
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

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO CUSTOMER (SSN, CUSTOMER_NAME, CUSTOMER_PHONE, CUSTOMER_ADDRESS) VALUES (@SSN, @CUSTOMER_NAME, @CUSTOMER_PHONE, @CUSTOMER_ADDRESS)";
            command.Parameters.AddWithValue("@SSN", ssn);
            command.Parameters.AddWithValue("@CUSTOMER_NAME", name);
            command.Parameters.AddWithValue("@CUSTOMER_PHONE", phone);
            command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);

            command.ExecuteNonQuery();

            Console.WriteLine("Customer added successfully!");
            Console.WriteLine("--------------------");
        }

        static void AddBankBranch(SqlConnection connection, int bankCode)
        {
            Console.WriteLine("*** Add bank branch(by admin) ***");

            // Get bank branch details from user as a input

            Console.WriteLine("Enter branch number:");
            int branchNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter branch address:");
            string branchAddress = Console.ReadLine();

            // Insert branch into the database

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO BRANCH (BANK_CODE, BRANCH_NUM, BRANCH_ADDRESS) " +
                "VALUES (@BANK_CODE, @BRANCH_NUM, @BRANCH_ADDRESS)";
            command.Parameters.AddWithValue("@BANK_CODE", bankCode);
            command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
            command.Parameters.AddWithValue("@BRANCH_ADDRESS", branchAddress);

            command.ExecuteNonQuery();

            Console.WriteLine("Bank branch added successfully!");
            Console.WriteLine("--------------------");
        }
    }
}
   