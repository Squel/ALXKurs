using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXKurs.Assignments.M2.L1
{
    public static class SeniorityServiceTest
    {
        public static void Run()
        {
            var seniorityService = new SeniorityService();

            var employee1 = new Employee("Michal", 2000, 1);
            var employee2 = new Employee("Tomasz", 6000, 8);
            var employee3 = new Employee("lukasz", 3000, 2);
            var employee4 = new Employee("Zbychu", 4500, 5);
            var employee5 = new Employee("Zdzichu", 3000, 3);
            var employee6 = new Employee("Ela", 2500, 3);
            var employee7 = new Employee("Zofia", 7000, 10);


            seniorityService.ClassifySeniorBySalary(employee1);
            seniorityService.ClassifySeniorBySalary(employee2);
            seniorityService.ClassifySeniorBySalary(employee3);
            seniorityService.ClassifySeniorBySalary(employee4);
            seniorityService.ClassifySeniorBySalary(employee5);


            Console.WriteLine("Sklasyfikowani po zarobkach: ");
            Console.WriteLine("Juniors: ");



            seniorityService.ClearLists();
            seniorityService.ClassifySeniorByExperience(employee1);
            seniorityService.ClassifySeniorByExperience(employee2);
            seniorityService.ClassifySeniorByExperience(employee3);
            seniorityService.ClassifySeniorByExperience(employee4);
            seniorityService.ClassifySeniorByExperience(employee5);


            Console.WriteLine("\n\nSklasyfikowani po doświadczeniu: ");
            Console.WriteLine("Juniors: ");



            Console.WriteLine("Juniors: ");

            Console.WriteLine("Mids: ");

            Console.WriteLine("Seniors: ");
        }
        public static void PresentEmployee(List<Employee> employees)
        {


            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}");



            }
        }
    }
}
