using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=reallyStrongPwd!";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            ReadUsers(connection);

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);

            var users = repository.GetAllWithRoles();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name}");
                foreach (var role in user.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }
    }
}
