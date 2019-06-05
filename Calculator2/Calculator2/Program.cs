//Programmer: John R. Adams
//Date: 06-06-2019

//Programming Exercise:
//
//1. Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
//2. In the Main() method of the console app, instantiate the class.
//3. Call the method in the class, passing in two numbers.
//4. Call the method in the class, specifying the parameters by name.


using System;


namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The result of the numbers passed into the object calculator are: ");
            Calculator2 calculator = new Calculator2(25,15);
            Console.WriteLine(calculator);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("The results of num1 and num2 passed to the Function are: ");
            calculator.Function(num1,num2);
            Console.WriteLine();
            Console.WriteLine(calculator);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
