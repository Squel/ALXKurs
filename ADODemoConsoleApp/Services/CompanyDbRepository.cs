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
                command.Parameters.AddWithValue("@id", employee.Id.ToString());
                command.Parameters.AddWithValue("@first_name", employee.First_name.ToString());
                command.Parameters.AddWithValue("@last_name", employee.Last_name.ToString());
                command.Parameters.AddWithValue("@email", employee.Email.ToString());
                command.Parameters.AddWithValue("@department_id", employee.Department_id.ToString());

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
        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();
            var queryString = "select * from employees";

            using (var connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var employee = new Employee
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            First_name = sqlDataReader[1].ToString(),
                            Last_name = sqlDataReader[2].ToString(),
                            Email = sqlDataReader[3].ToString(),
                            Department_id = Guid.Parse(sqlDataReader[4].ToString())
                        };
                        employees.Add(employee);
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

            return employees;
        }
        public Employee GetById(Guid Id)
        {
            var queryString = "select * from emplyee where employee.id=@id";
            var employees = new List<Employee>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                sqlCommand.Parameters.AddWithValue("@id", Id.ToString());
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();
                    
                    while (sqlDataReader.Read())
                    {
                        var employee = new Employee
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            First_name = sqlDataReader[1].ToString(),
                            Last_name = sqlDataReader[2].ToString(),
                            Email = sqlDataReader[3].ToString(),
                            Department_id = Guid.Parse(sqlDataReader[4].ToString())
                        };
                        employees.Add(employee);
                        
                    }
                    sqlDataReader.Close();
                    return employees.FirstOrDefault();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                connection.Close();
            }
        }
    }
}
