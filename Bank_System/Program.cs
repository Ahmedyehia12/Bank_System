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
            System.Console.WriteLine("Hello World!");

            var datasource = @"localhost";//your server
            var database = "bank_system"; //your database name
            var username = "SA"; //username of server to connect
            var password = "igpvmk123"; //password

            //your connection string 
            string connectionString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("ayhaga wenaby");
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
            Console.WriteLine("helkkkooooo");
            Console.ReadLine();
        }
    }
}