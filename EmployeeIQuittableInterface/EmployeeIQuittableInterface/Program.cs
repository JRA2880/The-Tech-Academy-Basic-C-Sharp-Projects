//Programmer: John R. Adams
//Date: 06-06-2019
//
//EXERCISE:
//
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//
//1.)  Create an interface called IQuittable and have it define a void method called Quit().
//
//2.) Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
//
//3.) Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIQuittableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "John";
            employee.lastName = "Adams";
            employee.quitReason = "I have decided to pursue my dream as a software developer, so I am attending the Tech Academy!";
            employee.notice = "6 month notice of resignation";
            employee.resignation = "It has been a pleasure to work here, but I have decided to move on from teaching in the Arabian Gulf.  Thank you for the opportunity.";
            employee.SayName();
            Console.WriteLine();

            IQuittable IQuit = employee;

            IQuit.Quit(employee);

            

            

        }
    }
}
