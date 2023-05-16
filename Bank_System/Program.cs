
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
            string connectionString = "Data Source=DESKTOP-FJPI0T1;Initial Catalog=BANK_APP;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM BANK";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["CODE"] + " " + reader["BANK_ADDRESS"] + " " + reader["BNAME"]);
            }
            Console.WriteLine("Connection Open ! ");
            connection.Close();
            Console.WriteLine("Connection closed ! ");
        }
    }
}
