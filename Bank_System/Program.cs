using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;
using System.Net;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan loan = new Loan();


            

            
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
            else
            {
                signUp();
            }




            // ---------------------------------------------------------
            // SIGN IN [AHMED YEHIA]
            // ---------------------------------------------------------
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
                    customerInterface();
                }
                else if (choice == 2)
                {
                    employeeInterface();
                }
                else
                {
                    adminInterface();
                }
            }

            static void customerInterface()
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

            static void employeeInterface()
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static void adminInterface()
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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
                    int code = GetMaxBankCode();
                    Console.WriteLine("Please enter Bank Address: ");
                    string address = Console.ReadLine();
                    Console.WriteLine("Please enter Bank Name: ");
                    string name = Console.ReadLine();
                    AddBank(code,address, name);
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




            // ---------------------------------------------------------
            // REQUIRED FUNCTIONS FOR SIGN UP [AHMED YEHIA]
            // ---------------------------------------------------------
            static void DisplayCustomers()
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static bool CheckSSN(int ssn)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static void UpdateCustomerData()
            {
                Console.WriteLine("Enter the customer's SSN: ");
                int ssn = int.Parse(Console.ReadLine());
                while (!CheckSSN(ssn))
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
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static bool checkId(int id)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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



            // ---------------------------------------------------------
            // SIGN UP [MERNA ISLAM]
            // ---------------------------------------------------------
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

                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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
                while(choice != 1 && choice != 2 && choice != 3)
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

                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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



            // ---------------------------------------------------------
            // ACCEPT/REJECT LOAN OPERATIONS [MERNA ISLAM]
            // ---------------------------------------------------------
            static void loanDecision(int accountNumber, int loanNum)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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
                            Console.WriteLine("Loan is rejected, insuffient balance for that loan amount [Minimum balance required is " + balance*5 + " ]");
                        }
                    }
                }
                connection.Close();
            }



            // ---------------------------------------------------------
            // REQUIRED FUNCTIONS FOR ACCEPT/REJECT LOAN OPERATIONS
            // ---------------------------------------------------------
            static void updateBalanceLoan(float balance, int accNum)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE ACCOUNT SET BALANCE = @new_balance WHERE ACCOUNT_NUM = @acc_num";
                command.Parameters.AddWithValue("@new_balance", balance);
                command.Parameters.AddWithValue("@acc_num", accNum);
                command.ExecuteReader();
                connection.Close();
            }

            static void updateLoanState(int loanNum, string decision)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE LOAN SET LOAN_STATE = @new_state WHERE LOAN_NUM = @loan_num";
                command.Parameters.AddWithValue("@new_state", decision);
                command.Parameters.AddWithValue("@loan_num", loanNum);
                command.ExecuteReader();
                connection.Close();
                
            }

            static float getBalance(int accountNum)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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




            // ---------------------------------------------------------
            // REQUEST LOAN OPERATION [AHMED YEHIA]
            // ---------------------------------------------------------
            static void requestLoan(int ssn)
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

                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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




            // ---------------------------------------------------------
            /// CHECKING FUNCTIONS [AHMED YEHIA]
            // ---------------------------------------------------------
            static bool checkBranchNum(int bnum)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static bool checkCustomerAccount(int ssn, int accNum)
            {
                bool check = false;
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static bool checkCustomerBranch(int ssn)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static int getLoanum()
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static int getEmployeeId()
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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


            // ---------------------------------------------------------
            /// DISPLAY FUNCTIONS [AHMED YEHIA]
            // ---------------------------------------------------------
            static void displayCustomerAccounts(int ssn)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            static void displayCustomerBranches(int ssn)
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM SERVES JOIN BRANCH ON SERVES.BRANCH_NUM = BRANCH.BRANCH_NUM JOIN BANK ON BRANCH.BANK_CODE = BANK.BANK_CODE";
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("Your branches: ");
                while (reader.Read())
                {
                    Console.WriteLine("Branch number: " + reader["BRANCH_NUM"].ToString() + "     Bank name:" + reader["BANK_NAME"]);
                }
                reader.Close();
            }


            // MARRRRIIIIAAAA

            static int GetMaxBankCode()
            {
                int maxBankCode = 0;
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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


            static int GetMaxSSN(SqlConnection connection)
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

            static void AddCustomer(SqlConnection connection)
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

            static void AddBankBranch(SqlConnection connection)
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

            static int getBranchNum()
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

            // NOOOOOORRRR

            static void DisplayALLCustomers()
            {
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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
                string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";
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

        }

        // NOURHAAAN

        public class Loan
        {
            public string CustName { get; set; }
            public string EmpName { get; set; }
            public decimal LoanAmount { get; set; }
            public string LoanType { get; set; }
            public string LoanNum { get; set; }
        }

        static void AddBank(int code, string address, string name)

        {
            string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";

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

         
        static void DisplayLoanForAdmin()
           {
                List<Loan> LOAN = new List<Loan>();
            string connectionString = @"Data Source=" + @"localhost;Initial Catalog= BANKAPP ;Persist Security Info=True;User ID= SA;Password= MyPassword123#";

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

    }
}