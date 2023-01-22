using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using ADODemoConsoleApp.Models;
using ADODemoConsoleApp.Services;

namespace ADODemoConsoleApp
{
    public class ADODemo
    {

        private string _connectionString;
        private CompanyDbRepository _companyDbRepository;

        public ADODemo(string connectionString)
        {
            _connectionString= connectionString;
            _companyDbRepository = new CompanyDbRepository(connectionString);
        }

        public void RunSelectAllFromEmployees()
        {
            var queryString = "Select * from employees";

            using var connection = new SqlConnection(_connectionString);
            var sqlCommand = new SqlCommand(queryString, connection);
            try
            {
                connection.Open();
                var sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"{sqlDataReader[0]},{sqlDataReader[1]},{sqlDataReader[2]},{sqlDataReader[3]}");
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void RunSelectedDefinedColumnSet(string column1, string column2, string column3)
        {
           

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var queryString = $"select {@column1}, {@column2}, {@column3} from employees";
                SqlCommand command = new SqlCommand(queryString, connection);
               // command.Parameters.AddWithValue("@column1", column1);
               // command.Parameters.AddWithValue("@column2", column2);
           
                try
                {
                    connection.Open();
                    var sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0]},{sqlDataReader[1]},{sqlDataReader[2]}");
                    }
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                connection.Close();
            }
        }

        public void InsertEmployeeDemo()
        {
            var employee = new Employee
            {
                id = Guid.NewGuid(),
                first_name = "Emil",
                last_name = "K",
                email = "Emil123@gmail.com",
                department_id = Guid.Parse("B03E90D0-459A-44E2-B970-98CFE795A122")
            };
            Console.WriteLine("Employee created");

            _companyDbRepository.InsertEmployeeToDb(employee);
            RunSelectAllFromEmployees();
        }
    }
}
