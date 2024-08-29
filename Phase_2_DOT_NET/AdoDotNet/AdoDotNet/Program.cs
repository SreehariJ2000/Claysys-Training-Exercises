using System;
using System.Data.SqlClient;

namespace AdoDotNet
{
     class Program
    {
        static void Main(string[] args)
        {
          
            string connectionString = "Data Source=LAPTOP-8CMGPOIT\\SQLEXPRESS;Initial Catalog=SambleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


            string sql = "SELECT * FROM Store";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
           
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["StoreID"]}, Place: {reader["Place"]}, begin at: {reader["Started_At"]}");
                }
            }
        }
    }
}