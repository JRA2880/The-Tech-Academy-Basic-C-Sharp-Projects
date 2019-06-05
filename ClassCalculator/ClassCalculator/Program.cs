using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            Calculator calculator = new Calculator();

            Console.WriteLine("Please enter a number for the class calculator to perform some math functions >> ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            int a = calculator.Add(number);
            int b = calculator.Subtract(number);
            int c = calculator.Multiply(number);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Console.WriteLine("The result of adding " + number + " to itself is : " + calculator.);
            Console.ReadLine();
        }
    }
}
