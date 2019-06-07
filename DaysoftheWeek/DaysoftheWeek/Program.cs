//John R. Adams
//Date: 06-07-2019
//
//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//
//1.) Create an enum for the days of the week.
//2.) Prompt the user to enter the current day of the week.
//3.) Assign the value to a variable of that enum data type you just created. 
//4.) Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysoftheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input;
                DaysoftheWeek dayEntered;
                bool isToday;

                Console.WriteLine("Please enter the current day of the week >>");
                input = Console.ReadLine();
                dayEntered = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), input, true);
                isToday = dayEntered == DaysoftheWeek.Thursday;

                if (isToday)
                {
                    Console.WriteLine("Yes, today is Thursday");
                }
                else
                {
                    Console.WriteLine("Sorry, that is not today.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The input that you entered was not recognized.");
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine("Please enter a day of the week: Monday, Tuesday, Wednesday, Thursday, Friday.");
            }
            finally
            {
                Console.WriteLine("Thank you for using the Days of the Week App.");
            }
          
        }
        public enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
