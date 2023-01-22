using ADODemoConsoleApp.Models;

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

        }
    }
}
