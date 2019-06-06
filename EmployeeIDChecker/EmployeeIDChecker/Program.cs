//Programmer: John R. Adams
//Date: 06-06-2019
//
//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1.) Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIDChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();

            employee1.fName = "Joe";
            employee1.lName = "Shmoe";
            employee1.ID = 1;

            employee2.fName = "George";
            employee2.lName = "Patton";
            employee2.ID = 1;

            employee3.fName = "Gustavo";
            employee3.lName = "Foy";
            employee3.ID = 3;

            employee4.fName = "Jade";
            employee4.lName = "Chan";
            employee4.ID = 4;

            EmployeeIDCheck(employee1, employee2);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine();
            EmployeeIDCheck(employee3, employee4);
            Console.ReadLine();
        }
        public static void EmployeeIDCheck(Employee name1, Employee name2)
        {
            if ( name1 == name2)
            {
                Console.WriteLine("Employee {0} and Employee {1} have the same Employee ID.",name1.lName,name2.lName);
                Console.WriteLine("Please manually change an Employee's ID so that there are no duplicate ID numbers.");

            }
            else
            {
                Console.WriteLine("Employee {0} and Employee {1} do not have the same Employee ID.",name1.lName,name2.lName);
                Console.WriteLine("There is no need to alter any Employee IDs.");
            }
        }
    }
}
