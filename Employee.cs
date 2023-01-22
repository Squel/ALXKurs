using System;
namespace ADODemoConsoleApp
{
	public class Employee
	{
		public Guid Id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set;}
		public string email { get; set; }	
		public Guid department_id { get; set; }
	}
}