﻿
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
            //UpdateCustomerData();
            // display customers
            DisplayCustomers();
        }

        static void DisplayCustomers()
        {
            string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM CUSTOMER";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("SSN: " + reader["SSN"].ToString());
                Console.WriteLine("Bank code: " + reader["CODE"].ToString());
                Console.WriteLine("Branch number: " + reader["BRANCHNUM"].ToString());
                Console.WriteLine("Bank address: " + reader["BANKADDRESS"].ToString());
                Console.WriteLine("Branch address: " + reader["BRANCHADDRESS"].ToString());
                Console.WriteLine("Bank name: " + reader["BANKNAME"].ToString());
                Console.WriteLine("--------------------------------------------------");
            }
            reader.Close();
            connection.Close();
        }
    


        // function to update customer's data
        static bool CheckSSN(int ssn)
        {
            string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM;Integrated Security=True";
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
        static bool checkBankCode(int code)
        {
            string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM BANK";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["CODE"].ToString() == code.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        static bool checkBranchNum(int bnum)
        {
            string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM BRANCH";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["BRANCHNUM"].ToString() == bnum.ToString())
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
       Console.WriteLine("Enter the customer's new Bank code , if you dont want to change his current bank just enter the same code: ");
       string bankCode = Console.ReadLine();
        while(!checkBankCode(int.Parse(bankCode)))
            {
            Console.WriteLine("This bank code is not found in the database, please enter a valid bank code: ");
            bankCode = Console.ReadLine();
        }
        Console.WriteLine("Enter the customer's new Branch number , if you dont want to change his current branch just enter the same number: ");
            string branchNum = Console.ReadLine();
            while (!checkBranchNum(int.Parse(branchNum)))
            {
                Console.WriteLine("This branch number is not found in the database, please enter a valid branch number: ");
                branchNum = Console.ReadLine();
            }
            Console.WriteLine("if you want to update the customer's phone number enter 1, if you dont want to update it enter 0: ");
            int choice = int.Parse(Console.ReadLine());
            string phoneNum = "";
            if (choice == 1)
            {
                Console.WriteLine("Enter the customer's new phone number: ");
                phoneNum = Console.ReadLine();
                while(phoneNum.Length != 11)
                {
                    Console.WriteLine("Invalid phone number, please enter a valid phone number: ");
                    phoneNum = Console.ReadLine();
                }
            }
            // upadte the customer's data
            string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_SYSTEM;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            // get bankaddress from bank code
            command.CommandText = "SELECT BANKADDRESS FROM BANK WHERE CODE = " + bankCode;
            SqlDataReader reader = command.ExecuteReader();
            string bankAddress = "";
            while (reader.Read())
            {
                bankAddress = reader["BANKADDRESS"].ToString();
            }
            reader.Close();
            // get branch address from branch number
            command.CommandText = "SELECT BRANCHADDRESS FROM BRANCH WHERE BRANCHNUM = " + branchNum;
            reader = command.ExecuteReader();
            string branchAddress = "";
            while (reader.Read())
            {
                branchAddress = reader["BRANCHADDRESS"].ToString();
            }
            reader.Close();
            // get bank name from bank code
            command.CommandText = "SELECT BANKNAME FROM BANK WHERE CODE = " + bankCode;
            reader = command.ExecuteReader();
            string bankName = "";
            while (reader.Read())
            {
                bankName = reader["BANKNAME"].ToString();
            }
             reader.Close();

            // update the customer's data
            if(choice == 1)
            {
                command.CommandText = "UPDATE CUSTOMER SET BANKCODE = " + bankCode + ", BRANCHNUM = " + branchNum + ", BANKADDRESS = '" + bankAddress + "', BRANCHADDRESS = '" + branchAddress + "', BANKNAME = '" + bankName + "', PHONENUM = '" + phoneNum + "' WHERE SSN = " + ssn;
            }
            else if(choice == 0)
            {
                command.CommandText = "UPDATE CUSTOMER SET BANKCODE = " + bankCode + ", BRANCHNUM = " + branchNum + ", BANKADDRESS = '" + bankAddress + "', BRANCHADDRESS = '" + branchAddress + "', BANKNAME = '" + bankName + "' WHERE SSN = " + ssn;
            }

            Console.WriteLine("Customer's data updated successfully !");
            connection.Close();
        }

    }
}
