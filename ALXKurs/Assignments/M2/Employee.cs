using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ALXKurs.Assignments.M2
{
    public class Employee
    {
        public string Name;
        public int Experience;
        public double Salary;

        public Employee(string name, int experience, double salary)
        {
            Name = name;
            Experience = experience;
            Salary = salary;
        }
    }
}
