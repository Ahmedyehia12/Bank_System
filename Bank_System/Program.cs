using System.Data.SqlClient;

namespace Bank_System{
    class Program{
        static void Main()
        {
            Console.WriteLine("         Welcome to our Banking System");
            Console.WriteLine("        -------------------------------");
            Console.WriteLine("Sign in as:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Employee");
            Console.WriteLine("3. Customer");
            Console.Write("your option => ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.Write("Invalid input, please enter your choice again => ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            if (choice == 1)
            {
                // TODO: add admin functionalities
            }
            else if (choice == 2)
            {
                Console.Write("Enter Employee ID: ");
                int empId = Convert.ToInt32(Console.ReadLine());
                while (!CheckEmpId(empId))
                {
                    Console.Write("Sorry this ID doesn't exist, please re-enter your ID: ");
                    empId = Convert.ToInt32(Console.ReadLine());
                }
                EmployeeView();
            }
            else
            {
                Console.Write("Enter Customer ID: ");
                int customerId = Convert.ToInt32(Console.ReadLine());
                while (!CheckCustomerId(customerId))
                {
                    Console.Write("Sorry this ID doesn't exist, please re-enter your ID: ");
                    customerId = Convert.ToInt32(Console.ReadLine());
                }
                CustomerView();
            }
        }

        static void EmployeeView()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("         Welcome ya employee ya amar");
            Console.WriteLine("        ------------------------------");
            Console.WriteLine("Choose one of the available options: ");
            Console.WriteLine("1. View all customers");
            Console.WriteLine("2. View all loans");
            Console.Write("your option => ");
            int option = Convert.ToInt32(Console.ReadLine());
            while (option != 1 && option != 2)
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.Write("Sorry option you chose is invalid, please re-enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1)
            {
                Console.WriteLine("---------------------------------------------");
                DisplayCustomers();
                Console.WriteLine("Choose one of the available options: ");
                Console.WriteLine("1. View all customers");
                Console.WriteLine("2. View all loans");
                Console.Write("your option => ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 2)
            {
                DisplayLoansForEmployee();
                Console.WriteLine("Choose one of the available options: ");
                Console.WriteLine("1. View all customers");
                Console.WriteLine("2. View all loans");
                Console.Write("your option => ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            // TODO: add employee functionalities
        }
        static void CustomerView()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("     Welcome ya customer ya habibi");
            Console.WriteLine("    -------------------------------");
            Console.WriteLine("Choose one of the available options: ");
            Console.WriteLine("1. Apply for a loan");
            Console.Write("your option => ");
            int option = Convert.ToInt32(Console.ReadLine());
            while (option != 1 && option != 2)
            {
                Console.Write("Sorry option you chose is invalid, please re-enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1)
            {
                DisplayLoansForCustomer();
                Console.WriteLine("Choose one of the available options: ");
                Console.WriteLine("1. Apply for a loan");
                Console.Write("your option => ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            //TODO: add functionalities of customer
        }
        static bool CheckCustomerId(int customerId)
        {
            string connectionString = "Data Source=DESKTOP-SH5P026;Initial Catalog=BankSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT SSN FROM CUSTOMER WHERE SSN = @customerId";
            command.Parameters.AddWithValue("@customerId", customerId);
            SqlDataReader reader = command.ExecuteReader();
            bool exists = reader.HasRows;
            if (exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckEmpId(int empId)
        {
            string connectionString = "Data Source=DESKTOP-SH5P026;Initial Catalog=BankSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT EMP_ID FROM EMPLOYEE WHERE EMP_ID = @empId";
            command.Parameters.AddWithValue("@empId", empId);
            SqlDataReader reader = command.ExecuteReader();
            bool exists = reader.HasRows;
            if (exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void DisplayCustomers()
        {
            string connectionString = "Data Source=DESKTOP-SH5P026;Initial Catalog=BankSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM CUSTOMER";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("SSN" + " CUSTOMER_NAME" +" CUSTOMER_ADDRESS" + " CUSTOMER_PHONE" + " BRANCH_NUM");
            while (reader.Read()){
                Console.WriteLine(reader["SSN"] + " " + reader["CUSTOMER_NAME"] + " " + reader["CUSTOMER_ADDRESS"]
                                  + " " + reader["CUSTOMER_PHONE"] + " " + reader["BRANCH_NUM"]);
            }
            connection.Close();
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        
        static void DisplayLoansForEmployee()
        {
            string connectionString = "Data Source=DESKTOP-SH5P026;Initial Catalog=BankSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM LOAN";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("LOAN_NUM     " + "| LOAN_TYPE     " +"| SSN_OF_CUSTOMER      " + "| LOAN_AMOUNT      " 
                              + "| BRANCH_NUM       " + "| EMP_ID");
            Console.WriteLine("---------------------------------------------------------------------------");
            while (reader.Read()){
                Console.WriteLine(reader["LOAN_NUM"] + "            | " + reader["LOAN_TYPE"] + "            " + reader["SSN"]
                                  + "       " + reader["LOAN_AMOUNT"] + "       " + reader["BRANCH_NUM"] + "        " + 
                                  reader["EMP_ID"]);
            }
            connection.Close();
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

        static void DisplayLoansForCustomer()
        {
            string connectionString = "Data Source=DESKTOP-SH5P026;Initial Catalog=BankSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT LOAN_TYPE FROM LOAN";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("----------");
            Console.WriteLine("LOAN_TYPE");
            Console.WriteLine("----------");
            while (reader.Read()){
                Console.WriteLine(reader["LOAN_TYPE"]);
            }
            connection.Close();
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
