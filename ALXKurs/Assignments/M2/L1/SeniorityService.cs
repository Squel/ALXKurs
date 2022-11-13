using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Assignments.M2.L1
{
    public class SeniorityService
    {
        List<Employee> JuniorEmployess;
        List<Employee> midEmployess;
        List<Employee> SeniorEmployee;

        public SeniorityService()
        {
            JuniorEmployess = new List<Employee>();
            midEmployess = new List<Employee>();
            SeniorEmployee = new List<Employee>();



        }
        public void ClassifySeniorBySalary(Employee employee)
        {

            if (employee.Salary < 2500)
            {
                JuniorEmployess.Add(employee);
            }
            else if (employee.Salary > 6000)
            {
                SeniorEmployee.Add(employee);
            }
            else
            {
                midEmployess.Add(employee);

            }


        }

        public void ClassifySeniorByExperience(Employee employee)
        {
            if (employee.Experience < 2)
            {
                JuniorEmployess.Add(employee);
            }
            else if (employee.Experience > 6)
            {
                SeniorEmployee.Add(employee);
            }
            else
            {
                midEmployess.Add(employee);

            }


        }
        public void ClearLists()
        {
            JuniorEmployess.Clear();
            midEmployess.Clear();
            SeniorEmployee.Clear();

        }
    }
}
