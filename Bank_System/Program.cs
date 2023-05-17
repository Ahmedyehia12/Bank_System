
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

            string connectionString = "Data Source=LAPTOP-IGRK5UC3;Initial Catalog=BankSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM BANK";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["BANK_CODE"] + " " + reader["BANK_ADDRESS"] + " " + reader["BANK_NAME"]);
            }

            Console.WriteLine("Connection Open ! ");
            connection.Close();

            Console.WriteLine("Connection closed ! ");

            BankSystem bankSystem = new BankSystem();
            
            //bankSystem.AddBank(2067, "cairo", "ALX"); //remember to delete it from the db itself before running again
            //bc the pk cant have duplicates
            
            bankSystem.DisplayLoan();
        }

    }


   
    public class Bank
    {
        public int Code { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class Loan
    {
        public string CustName { get; set; }
        public string EmpName { get; set; }
        public decimal LoanAmount { get; set; }
        public string LoanType { get; set; }
        public string LoanNum { get; set; }
    }

    public class BankSystem
    {
        /**
             * readonly: access modifier to declare a member typically a field,
             * once a val is assigned at the time of declaration
             * it cant be modified again.
             */
        private readonly string connectionString =
            "Data Source=LAPTOP-IGRK5UC3;Initial Catalog=BankSystem;Integrated Security=True";

        public void AddBank(int code, string address, string name)
        {
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


        /**
         * DisplayLoan() creates a list of Loan objs to
         * hold the data retrieved from the db
         */
        public void DisplayLoan()
        {
            List<Loan> LOAN = new List<Loan>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT LOAN_AMOUNT,LOAN_TYPE,LOAN_NUM" +
                               "FROM LOAN" +
                               "INNER JOIN CUSTOMER ON LOAN.SSN = CUSTOMER.SSN" +
                               "INNER JOIN EMPLOYEE ON LOAN.SSN = EMPLOYEE.EMP_ID";
                    /*"SELECT LOAN.LoanAmount, LOAN.LoanType, LOAN.LoanNum, CUSTOMER.CustName, EMPLOYEE.EmpName" +
                               "FROM LOAN " +
                               "INNER JOIN CUSTOMER CUSTOMER ON LOAN.SSN = CUSTMOER.SSN " +
                               "INNER JOIN EMP_ID EMPLOYEE ON LOAN.SSN = EMPLOYEE.EMP_ID";
                               */

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
                            LoanNum = reader["LoanNum"]?.ToString(),
                            LoanType = reader["LoanType"]?.ToString(),
                            LoanAmount = Convert.ToDecimal(reader["LoanAmount"]??0),
                            CustName = reader["CustName"]?.ToString(),
                            EmpName = reader["EmpName"]?.ToString()
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
            {
                
            }
        }
    }
}
