//Programmer: John R. Adams
//Date 06-04-2019
//
//Programming Exercise:
//
//REQUIREMENTS:
//
//1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return a integer result.
//2. In the Main() method of the console app, instantiate the class.
//3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
//4. Call the method in the class, passing in the one or two numbers entered.
//5. Try various combinations of numbers on the code, including having no second number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num1;
            int num2;
            Calculator4 calculator = new Calculator4();

            Console.WriteLine("Thank you for using Calculator4!  The latest in class Calculator code tech! (Sort of!). \n");
            Console.Write("Please enter a number for the first number >> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter a number for the second number.");
            Console.WriteLine("This is optional, if you don't want to enter a number, just press 1.");
            Console.WriteLine("Please enter a number for the second number or press 1 to skip >> ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int c = calculator.Function(num1);

            int d = calculator.Function(num1, num2);

            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(d);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
