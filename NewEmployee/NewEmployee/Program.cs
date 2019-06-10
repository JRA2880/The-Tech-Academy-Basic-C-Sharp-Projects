//Programmer: John R. Adams
//Date: 06-10-2019
//
//
//EXERCISE:
//
//1.) Create a const variable

//2.) Create a variable using the keyword "var".

//3.) Chain two constructors together.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            const string COMPANY = "The Time Bureau";

            var newEmployee1 = new Employee("Billy", "The Kid",1,100.00);
            var newEmployee2 = new Employee("Maximus", "Decimus",2,100.00);

            var newEmployee3 = new Employee("Lizzie", "Borden");
            var newEmployee4 = new Employee("Marilyn", "Monroe");
            newEmployee3.EmployeeId = 3;
            newEmployee4.EmployeeId = 4;

            Console.WriteLine("Welcome to " + COMPANY + " , it is an honor to have you joining our ranks. \n");

            newEmployee1.HelloNewEmployee(newEmployee1);
            Console.WriteLine();
            newEmployee2.HelloNewEmployee(newEmployee2);
            Console.WriteLine();
            newEmployee3.HelloNewEmployee(newEmployee3);
            Console.WriteLine();
            newEmployee4.HelloNewEmployee(newEmployee4);




        }
    }
}
