using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;
using System.Net;
namespace Bank_System
{
   public partial class Admin
    {
        public static void adminInterface()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            Console.WriteLine("Welcome to our bank, what do you want to do?");
            Console.WriteLine("1- Add a new Bank");
            Console.WriteLine("2- Add a new Branch");
            Console.WriteLine("3- Display list of Customers");
            Console.WriteLine("4- Display list of Loans");
            Console.WriteLine("5- Display list of Loans with Customer and Empolyee Names");

            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5)
            {
                Console.WriteLine("Invalid choice, please enter a valid choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                int code = Admin.GetMaxBankCode();
                Console.WriteLine("Please enter Bank Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Please enter Bank Name: ");
                string name = Console.ReadLine();
                AddBank(code, address, name);
            }
            else if (choice == 2)
            {
                AddBankBranch(connection);
            }
            else if (choice == 3)
            {
                DisplayALLCustomers();
            }
            else if (choice == 4)
            {
                DisplayLoansForEmployee();
            }
            else
            {
                DisplayLoanForAdmin();
            }
        }
        static void DisplayALLCustomers()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM CUSTOMER";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("SSN" + "\t" + " CUSTOMER_NAME" + "\t" + " CUSTOMER_ADDRESS" + "\t" + " CUSTOMER_PHONE");
            while (reader.Read())
            {
                Console.WriteLine(reader["SSN"] + "\t\t" + reader["CUSTOMER_NAME"] + "\t\t" + reader["CUSTOMER_ADDRESS"]
                                  + "\t\t" + reader["CUSTOMER_PHONE"]);
            }
            connection.Close();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        static void DisplayLoansForEmployee()
        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM LOAN";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("LOAN_NUM " + "\t LOAN_TYPE " + "\t SSN_OF_CUSTOMER " + "\t LOAN_AMOUNT "
                              + "\t BRANCH_NUM " + "\t EMP_ID" + "\t LOAN_STATE");
            Console.WriteLine("---------------------------------------------------------------------------");
            while (reader.Read())
            {
                Console.WriteLine(reader["LOAN_NUM"] + " \t\t " + reader["LOAN_TYPE"] + " \t\t " + reader["SSN"]
                                  + " \t\t " + reader["LOAN_AMOUNT"] + " \t\t " + reader["BRANCH_NUM"] + " \t\t " +
                                  reader["EMP_ID"] + " \t\t " + reader["LOAN_STATE"]);
            }
            connection.Close();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        public class Loan
        {
            public string CustName { get; set; }
            public string EmpName { get; set; }
            public decimal LoanAmount { get; set; }
            public string LoanType { get; set; }
            public string LoanNum { get; set; }
        }

       public static void AddBank(int code, string address, string name)

        {
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BANK (BANK_CODE, BANK_ADDRESS, BANK_NAME)" +
                               "VALUES (@Code, @Address, @Name)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", code);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Address", address);

                    connection.Open();

                    int rows = command.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rows}");
                }
            }

            Console.WriteLine("Bank added successfully");
        }
       public static void DisplayLoanForAdmin()
        {
            List<Loan> LOAN = new List<Loan>();
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LOAN JOIN CUSTOMER ON LOAN.SSN = CUSTOMER.SSN JOIN EMPLOYEE ON LOAN.EMP_ID = EMPLOYEE.EMP_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                { //here put Sql instead of var
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Loan loan = new Loan
                        {
                            //LoanNum = reader["LoanNum"].ToString(),
                            //possible null reference assignment
                            LoanNum = reader["LOAN_NUM"]?.ToString(),
                            LoanType = reader["LOAN_TYPE"]?.ToString(),
                            LoanAmount = Convert.ToDecimal(reader["LOAN_AMOUNT"] ?? 0),
                            CustName = reader["CUSTOMER_NAME"]?.ToString(),
                            EmpName = reader["EMP_NAME"]?.ToString()
                        };

                        /*
                         * Add method is a member of the List<T> class
                         * used to add an element to the end of the list
                         */
                        LOAN.Add(loan);
                    }

                    reader.Close();
                }
            }

            if (LOAN.Count == 0)
            {
                Console.WriteLine("No loans found.");
                return;
            }

            Console.WriteLine("Loan List: ");
            foreach (var loan in LOAN)
            {
                Console.WriteLine($"Loan Number: {loan.LoanNum}");
                Console.WriteLine($"Customer Name: {loan.CustName}");
                Console.WriteLine($"Employee Name: {loan.EmpName}");
                Console.WriteLine($"Loan Type: {loan.LoanType}");
                Console.WriteLine($"Loan Amount: {loan.LoanAmount}");
                Console.WriteLine("----------");
            }
            Console.ReadLine();
        }

      public static int GetMaxBankCode()
        {
            int maxBankCode = 0;
            string connectionString = @"Data Source=" + @"ahmedyehia.database.windows.net;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= admon;Password= 12345678AB_";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand commandBankCode = connection.CreateCommand();
            commandBankCode.CommandText = "SELECT MAX(BANK_CODE) AS MaxBankCode FROM BANK";
            SqlDataReader reader = commandBankCode.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MaxBankCode")))
                {
                    maxBankCode = (int)reader["MaxBankCode"];
                }
            }

            reader.Close();
            connection.Close();

            return maxBankCode + 1;
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
        public static void AddBankBranch(SqlConnection connection)
        {
            Console.WriteLine("*** Add bank branch(by admin) ***");

            // Get bank branch details from user as a input
            Console.WriteLine("Enter bank code:");
            int bankCode = Convert.ToInt32(Console.ReadLine());

            int branchNum = getBranchNum();


            Console.WriteLine("Enter branch address:");
            string branchAddress = Console.ReadLine();


            // Insert branch into the database
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO BRANCH (BANK_CODE, BRANCH_NUM, BRANCH_ADDRESS) " +
                "VALUES (@BANK_CODE, @BRANCH_NUM, @BRANCH_ADDRESS)";
            command.Parameters.AddWithValue("@BANK_CODE", bankCode);
            command.Parameters.AddWithValue("@BRANCH_NUM", branchNum);
            command.Parameters.AddWithValue("@BRANCH_ADDRESS", branchAddress);

            command.ExecuteNonQuery();

            Console.WriteLine("Bank branch added successfully!");
            Console.WriteLine("--------------------");
            connection.Close();
        }


    }


}

