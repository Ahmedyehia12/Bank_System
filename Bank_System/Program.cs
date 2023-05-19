using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;
using System.Net;


namespace Bank_System
{
    partial class Program
    {
        static void Main(string[] args)
        {

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

                    Customer.customerInterface();
                }
                else if (choice == 2)
                {

                    Employee.employeeInterface();
                }
                else
                {

                    Admin.adminInterface();
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
                    Customer.customerSignUp();
                }
                else
                {
                    Employee.employeeSignUp();
                }
            }

        }
    }
}