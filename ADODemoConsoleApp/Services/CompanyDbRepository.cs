using ADODemoConsoleApp.Models;
using System.Data.SqlClient;

namespace ADODemoConsoleApp.Services
{
    public class CompanyDbRepository
    {
        private string _connectionString;

        public CompanyDbRepository( string connectionString)
        {
            _connectionString = connectionString;
        }
        public void InsertEmployeeToDb( Employee employee)
        {
            var queryString = "insert into employees(id, first_name, last_name, email, department_id)" + "values(@id, @first_name, @last_name, @email, @department_id)";

            using (SqlConnection connection = new SqlConnection( _connectionString ))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", employee.id.ToString());
                command.Parameters.AddWithValue("@first_name", employee.first_name.ToString());
                command.Parameters.AddWithValue("@last_name", employee.last_name.ToString());
                command.Parameters.AddWithValue("@email", employee.email.ToString());
                command.Parameters.AddWithValue("@department_id", employee.department_id.ToString());

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
