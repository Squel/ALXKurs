namespace ADODemoConsoleApp.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public Guid Department_id { get; set; }
    }
}