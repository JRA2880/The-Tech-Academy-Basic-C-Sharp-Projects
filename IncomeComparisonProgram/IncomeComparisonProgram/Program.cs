//Programmer: John R. Adams
//Date: 06-01-2019

//Program Exercise:
//Your job is to create an anonymous income comparison program.

//REQUIREMENTS:

//1.) The program must start by printing “Anonymous Income Comparison Program” to the screen.

//2.) It must then print “Person 1” to the screen and get the following details:

//3.) Hourly Rate

//4.) Hours worked per week

//5.) It must then print “Person 2” to the screen and then get the following details:

//6.) Hourly rate

//7.) Hours worked per week

//8.) It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.

//9.) It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.

//10.) It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.

using System;


namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            string input;
            double person1HourlyRate;
            double person1Hours;
            double person1salary;
            double person2HourlyRate;
            double person2Hours;
            double person2salary;
            bool isSalary1MoreThanSalary2;

            Console.WriteLine("Anonymous Income Program");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Program will start with person 1 income information >>");
            Console.WriteLine();
            Console.Write("Person 1, please enter your hourly rate >> ");
            input = Console.ReadLine();
            person1HourlyRate = Convert.ToDouble(input);

            Console.WriteLine();
            Console.Write("Person 1, please enter the number of hours worked per week >> ");
            input = Console.ReadLine();
            person1Hours = Convert.ToDouble(input);
            person1salary = ((person1HourlyRate * person1Hours) * 4) * 12;

            Console.WriteLine();
            Console.WriteLine("Now the Program will take Peron 2 income infomration >> ");
            Console.Write("Person 2, please enter your hourly rate >> ");
            input = Console.ReadLine();
            person2HourlyRate = Convert.ToDouble(input);

            Console.WriteLine();
            Console.Write("Person 2 please enter the number of hours worked per week >> ");
            input = Console.ReadLine();
            person2Hours = Convert.ToDouble(input);
            person2salary = ((person2HourlyRate * person1Hours) * 4) * 12;

            Console.WriteLine();
            Console.WriteLine("The annual salary of Person 1 is {0}.", person1salary.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("The annual salary of Person 2 is {0}.", person2salary.ToString("C"));

            if (person1salary > person2salary)
            {
                isSalary1MoreThanSalary2 = true;
                Console.WriteLine("Does Person 1 make more money than Person 2?");
                Console.WriteLine(isSalary1MoreThanSalary2);
            }
            else {
                isSalary1MoreThanSalary2 = false;
                Console.WriteLine("Does Person 1 make more money than Person 2?");
                Console.WriteLine(isSalary1MoreThanSalary2);
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Anonymous Income Program!");
            Console.ReadLine();
        }
    }
}
