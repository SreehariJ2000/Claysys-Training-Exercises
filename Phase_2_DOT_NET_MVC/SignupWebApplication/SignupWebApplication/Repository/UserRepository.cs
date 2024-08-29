using SignupWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SignupWebApplication.Repository
{
    public class UserRepository
    {
    
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

        public void AddUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("spInsertUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@User_Password", user.User_Password);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var adapter = new SqlDataAdapter("spGetAllUserData", connection))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        users.Add(new User
                        {
                            UserID = Convert.ToInt32(row["UserID"]),
                            FirstName = row["FirstName"].ToString(),
                            LastName = row["LastName"].ToString(),
                            Email = row["Email"].ToString(),
                            User_Password = row["User_Password"].ToString(),
                            Phone = row["Phone"].ToString()
                        });
                    }
                }
            }
            return users;
        }
    }

}