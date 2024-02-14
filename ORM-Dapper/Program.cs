using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection connection = new MySqlConnection(connString);
            
            //var departmentRepo = new DapperDepartmentRepository(conn);

            //var departments = departmentRepo.GetAllDepartments();

            //foreach (var department in  departments)
            //{
            //    Console.WriteLine(department.DepartmentID);
            //    Console.WriteLine(department.Name);
            //}
            var repo = new DapperProductRepository(connection);
        }
    }
}
