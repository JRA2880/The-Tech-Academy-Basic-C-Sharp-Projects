using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIQuittableInterface
{
    public class Employee : Person, IQuittable
    {
        public string quitReason { get; set; }
        public string notice { get; set; }
        public string resignation { get; set; }
        public override void SayName()
        {
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name:  {0}", lastName);
        }

            public void Quit(Employee employee)
            {
                Console.WriteLine("Employe {0} {1} decides to: \n ", firstName, lastName);
                Console.WriteLine("Quit...");
                Console.WriteLine("Employee reason for quitting: {0}", quitReason);
                Console.WriteLine("Employee length of notice: {0}", notice);
                Console.WriteLine("Employee resignation: {0}", resignation);
            }
    }
          
}

