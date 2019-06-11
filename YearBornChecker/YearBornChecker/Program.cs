//Programmer: John R. Adams
//Date: 06-11-2019
//
//EXERCISE:
//
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//
//1.) Ask the user for his or her age.

//2.) Display the year user born.

//3.) Exceptions must be handled using "try .. catch".

//4.) Display appropriate error messages if user enters zero or negative numbers.

//5.) Display a general message if exception caused by anything else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearBornChecker
{
    class Program
    {
        public static int Age(int birthdate)
        {
            const int thisYear = 2019;
            int currentAge =  thisYear - birthdate;
            return currentAge;
        }
        static void Main(string[] args)
        {
            try
            {
                const int thisYEAR = 2019;
                bool validYear = false;
                int userBirthDate;
                int currentAge;
               
                while (!validYear)
                {
                    Console.Write("Enter your birth year to determine how old you are >> ");
                    validYear = int.TryParse(Console.ReadLine(), out userBirthDate);
                    if (!validYear)
                    {
                        throw new ArgumentException();
                    }
                    if (userBirthDate <= -1 || userBirthDate == 0)
                    {
                        throw new InvalidYearException();
                    }
                    if (userBirthDate > thisYEAR)
                    {
                        throw new Exception();
                    }
                    currentAge = Age(userBirthDate);
                    Console.WriteLine();
                    Console.WriteLine("You were born in {0}.", userBirthDate.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Your current age is {0} in {1}.", currentAge.ToString(),thisYEAR.ToString());
                    Console.WriteLine();
                }            
            }
            catch(InvalidYearException)
            {
                Console.WriteLine("Please enter a year greater than -1 or 0.");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please only enter whole numbers.");
                Console.WriteLine("Please do not enter digits or letters.");
            }
            catch(Exception)
            {
                Console.WriteLine("Something, does not bode well...the System Administrator must be summoned to resolve this issue...");
                Console.WriteLine("Summoning the System Administrator into existence...");
                Console.WriteLine("Go ahead and make a cup of tea, check the news, this may take a bit...");
                Console.WriteLine("Just real quick, have you figured out how to time travel....");
                Console.WriteLine("Are you a member of the Time Bureau...");
            } 
            finally
            {
                Console.WriteLine("Thank you for using the Current Age Program.");
                Console.WriteLine("And remember, you are only as old as you feel!");
            }
        }
    }
}
