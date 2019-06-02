//Programmer: John R. Adams
//Date: 06-022019

//Program Exercise:

//Your job is to create a console-based application for getting a shipping quote for a package.

//REQUIREMENTS:

//1.) The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”

//2.) The user must then be prompted for the package weight.

//3.) If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.

//4.) The user must then be prompted for the package width.

//5.) Then the package height.

//6.) Then the package length.

//7.) If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

//8.)The sum total of dimensions are then multiplied by the weight and divided by 100.

//9.) The result of that calculation is the quote.

//10.) Display the quote to the user as a dollar amount.

//Example: 

//Welcome to Package Express.

//Please follow the instructions below.

//Please enter the package weight:
// 40
//Please enter the package width:
// 5
//Please enter the package height:
// 3
//Please enter the package length:
// 3
//Your estimated total for shipping this package is: $4.40
//
//Thank you.


using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            string input;
            double weight;
            double width;
            double height;
            double length;
            double dimensionTotal;
            double quote;

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tWelcome to Package Express");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please follow the instructions below to ship your package:  ");
            Console.WriteLine();
            Console.Write("Please enter the weight of your package >> ");
            input = Console.ReadLine();
            weight = Convert.ToDouble(input);

            if (weight > 50.0)
            {
                Console.WriteLine("Package too big to be shipped by Package Express.");
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You entered {0} for the weight of the package to be shipped.",weight.ToString());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Please enter the width of your package >>   ");
            input = Console.ReadLine();
            width = Convert.ToDouble(input);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Please enter the height of your package >>  ");
            input = Console.ReadLine();
            height = Convert.ToDouble(input);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Please enter the length of your package >>  ");
            input = Console.ReadLine();
            length = Convert.ToDouble(input);
            Console.WriteLine();

            dimensionTotal = width + height + length;

            if (dimensionTotal > 50.0)
            {
                Console.WriteLine("Package too big to be shipped by Package Express.  Have a good day.");
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine("The total dimensions of the package to be shipped are {0}.",dimensionTotal.ToString());
                Console.WriteLine();
            }

            quote = (dimensionTotal * weight) / 100.0;

            Console.WriteLine();
            Console.WriteLine("The total amount for your shipment is {0}.", quote.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Thank you for choosing Package Express!");
        }
    }
}
