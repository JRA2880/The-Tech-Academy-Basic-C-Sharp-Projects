//Programmer: John R. Adams
//Date: 06-04-2019
//
//Programming Assignment: 
//
//In a console app, create code that does the following:
//
//1.) Create a list of integers. 
//2.) Ask the user for a number to divide each number in the list by. 
//3.) Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
//4.) Run that code, entering in non-zero numbers as the user. Look at the displayed results.
//5.) Run that code, entering in zero as the number to divide by. Note any error messages you get.
//6.) Run that code, entering in a string as the number to divide by. Note any error messages you get.
//7.) Now put the loop in a try/catch block.
//8.) Below and outside of the try/catch block, 
//    make the program display a message to the display to let you know the program has emerged from 
//    the try/catch block and continued on with program execution. 
//9.) In the catch block, display the error message to the screen. 
//10.) Then try various combinations of user input: valid numbers, zero and a string. 
//11.) Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main()
        {   try
            {
                List<int> numberList = new List<int>() { 2, 4, 6, 8, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
                string input;
                int index;
                int divider;
                int answer;
                Console.Write("Enter a number to divide each number in the number list >> ");
                input = Console.ReadLine();
                divider = Convert.ToInt32(input);

                foreach (int number in numberList)
                {
                    answer = number / divider;
                    Console.WriteLine(number + " divided by " + divider + " = " + answer);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number >>");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for dividing your number by the number list today.");
                Console.WriteLine("There is always more fun with math!");
                Console.ReadLine();
            }
          
        }
    }
}

