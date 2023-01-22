using System.Data.SqlClient;

namespace ADODemoConsoleApp
{
    public class ADODemo
    {

        private string _connectionString;

        public ADODemo(string connectionString)
        {
            _connectionString= connectionString;
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
            }
        }
    }
}
