//Programmer: John R. Adams
//Date: 06-02-2019

//Program Exercise:
//EXERCISE: BOOLEAN LOGIC
// Program Purpose:
//Your job is to create a basic approval program for car insurance.
//It will ask the applicant some questions and return a “true” or “false” at the end as to whether or not the applicant qualified for car insurance.

//REQUIREMENTS

//Ask the following questions:

//1.) What is your age?

//2.) Have you ever had a DUI?

//3.)How many speeding tickets do you have?

//Use the following qualification rules to determine if the applicant qualifies for car insurance:

//A.) Applicants must be over 15 years old.

//B.) Applicants must not have any DUI’s.

//C.) Applicants must not have more than 3 speeding tickets.

//5.) Print the result of the boolean expression created from the above business rules.

using System;


namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            string input;
            int age;
            string DUI;
            int speedingTicket;
            bool isqualified;

            Console.WriteLine("Welcom TA Insurance!");
            Console.WriteLine();
            Console.WriteLine("To get started, please answer the following questions to determine if you qualify for car insurance >> ");
            Console.WriteLine();
            Console.Write("Please enter your age.  Please enter only a whole number >> ");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);
            Console.WriteLine();
            Console.Write("Have you ever had a DUI?  Please answer yes or no >> ");
            DUI = Console.ReadLine();
            Console.WriteLine();
            Console.Write("How many speeding tickets do you have? Please enter a whole number >> ");
            input = Console.ReadLine();
            speedingTicket = Convert.ToInt32(input);
            Console.WriteLine();
            if (age > 15 && DUI == "no" && speedingTicket <= 3)
            {
                isqualified = true;
                Console.WriteLine("Do you qualify for car insurance?");
                Console.WriteLine(isqualified);
                Console.ReadLine();
            }
            else if (age <= 15 && DUI == "no" && speedingTicket <= 3)
            {
                isqualified = false;
                Console.WriteLine("Sorry, you are too young to qualify for car insurance.");
                Console.WriteLine(isqualified);
                Console.ReadLine();
            }
            else if (age > 15 && DUI == "yes" && speedingTicket <= 3)
            {
                isqualified = false;
                Console.WriteLine("Sorry, you don't qualify for car insurance, you have a DUI.");
                Console.WriteLine(isqualified);
                Console.ReadLine();
            }
            else if (age > 15 && DUI == "no" && speedingTicket > 3)
            {
                isqualified = false;
                Console.WriteLine("Sorry, you don't qualify for car insurance, you have more than 3 speeding tickets.");
                Console.WriteLine(isqualified);
                Console.ReadLine();
            }
            else
            {
                isqualified = false;
                Console.WriteLine("Sorry, you don't qualify for car insurance, please visit a TA Insurance office or speak to a TA insurance representative to determine why you don't qualify for car insurance.");
                Console.WriteLine(isqualified);
                Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using TA Insurance!");
            Console.WriteLine("Helping Software Developers get car insurance since 2014!");
            Console.ReadLine();
        }
    }
}
