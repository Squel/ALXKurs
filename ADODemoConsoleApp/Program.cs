// See https://aka.ms/new-console-template for more information
using System;
using ADODemoConsoleApp;

Console.WriteLine("Hello, World!");
var connectionString = "Data Source=DESKTOP-UOE11SG\\SQLEXPRESS; Initial Catalog=company; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
ADODemo demo = new ADODemo(connectionString);
Console.WriteLine("Select all from table");
demo.RunSelectAllFromEmployees();
Console.WriteLine("---------------------");
Console.WriteLine("Select columns");
demo.RunSelectedDefinedColumnSet("first_name", "last_name", "email");
Console.WriteLine("---------------------");
Console.WriteLine("Insert to DB");
//demo.InsertEmployeeDemo();
demo.ManyEmployee();
