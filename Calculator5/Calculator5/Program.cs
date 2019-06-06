//Programmer: John R. Adams
//Date: 06-06-2019
//
//EXERCISE:
//
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//
//1.) Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2.) In the Main() method, instantiate that class.

//3.) Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

//4.) Create a method with output parameters.

//5.) Overload a method.

//6). Declare a class to be static.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int area;
            String input;

            Calculator calculator = new Calculator();

            Console.Write("Enter a number to be used by Calculator5 >> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            calculator.Function(num1);
            Console.WriteLine();
            Console.Write("Enter the first number to calculate the area of the shape >> ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number to calculate the area of the shape >> ");
            num3 = Convert.ToInt32(Console.ReadLine());
            area = calculator.Function(num2, num3,out area);
            Console.WriteLine();
            Console.WriteLine("The area of the shape with the numbers {0} and {1} is {2}.", num2,num3,area);
            Console.WriteLine();
            Console.Write("Enter a your name >> ");
            input = Console.ReadLine();
            string d = calculator.Function(input);
            Console.WriteLine(d);
            Console.WriteLine();
            Mathematician.details();
            Console.WriteLine("Mathematician First Name:     {0}", Mathematician.M_fname);
            Console.WriteLine("Mathematician Last Name:      {0}", Mathematician.M_lname);
            Console.WriteLine("Mathematician famous formula: {0}", Mathematician.M_formula);
            Console.WriteLine("Mathematician famous quote:   {0}", Mathematician.M_quote);
            Console.ReadLine();

        }
    }
}
