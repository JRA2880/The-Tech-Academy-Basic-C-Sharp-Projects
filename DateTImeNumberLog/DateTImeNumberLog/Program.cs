//Programmer: John R. Adams
//Date: 06-09-2019
//
//EXERCISE:
//
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//
//1.) Prints the current date and time to the console.
//2.) Asks the user for a number
//3.) Prints to the console the exact time it will be in X hours, being the number the user entered
//    in step 2.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTImeNumberLog
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            DateTime currentDate = DateTime.Now;
            int currentHour = currentDate.Hour;
            DateTime futureDate;

            Console.WriteLine("The current date is : {0}",currentDate);
            Console.WriteLine("The current hour is : {0}:00 military time.",currentHour);

            Console.Write("Please enter a number to determine what the exact time will be >> ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            futureDate = currentDate.AddHours(number);

            Console.WriteLine("The date from {0} hours from now will be {1}.",number,futureDate);
            



        }
    }
}
