//Programmer: John R. Adams
//Date: 06-02-2019

//EXERCISE:
//CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:
//1.) Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).

//2.) Takes an input from the user, adds 25 to it, and prints the result to the console.

//3.) Takes an input from the user, divides it by 12.5, and prints the result to the console.

//4.) Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.

//5.) Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).

using System;


namespace TechAcademyConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            string input;
            double int1;
            double int2;
            double int3;
            int int4;
            bool isTrueOrFalse;
            int remainder;

            Console.WriteLine("Thank you for using the Tech Academy Calculator Today!");
            Console.WriteLine("Please follow the prompts from the console to use the Tech Academy Calculator!");
            Console.WriteLine();
            Console.WriteLine("Please enter a number that will be multiplied.  Please don't enter a number greater than 10,000! >> ");
            input = Console.ReadLine();
            int1 = Convert.ToDouble(input);
            int1 = int1 * 50;
            Console.WriteLine("The result of  your number multiplied by 50 is: " + int1);
            Console.WriteLine();
            Console.WriteLine("Please enter a number that will be added to. Please don't enter a number greater than 10,000! >> ");
            input = Console.ReadLine();
            int2 = Convert.ToDouble(input);
            int2 = int2 + 25;
            Console.WriteLine("The result of your number added by 25 is: " + int2);
            Console.ReadLine();
            Console.WriteLine("Please enter a number that will be divided by another number.  Pleae don't enter a number greater than 10,000! >> ");
            input = Console.ReadLine();
            int3 = Convert.ToDouble(input);
            int3 = int3 / 12.5;
            Console.WriteLine("The result o  your input is: " + int3);
            Console.WriteLine();
            Console.WriteLine("Please enter a number to determine whether the statment is true or false.  Please don't enter a number greater than 50! >>");
            input = Console.ReadLine();
            int4 = Convert.ToInt32(input);

            if (int4 > 50)
            {
                isTrueOrFalse = true;
                Console.WriteLine("The number " + int4 + " is greater than 50! That is true!");
            }
            else {
                isTrueOrFalse = false;
                Console.WriteLine("The number " + int4 + " is lesser than 50...That is false!");
            }
            Console.WriteLine();
            Console.WriteLine("Enter a number that will be divided by another number and the remainder will be provided.  Please don't enter a number greater than 10,000! >> ");
            input = Console.ReadLine();
            remainder = Convert.ToInt32(input);
            remainder = remainder % 7;
            Console.WriteLine("The remainder of the number entered divided by 7 is " + remainder);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Tech Academy Console Calculator!!!");
            Console.ReadLine();

        }
    }
}
