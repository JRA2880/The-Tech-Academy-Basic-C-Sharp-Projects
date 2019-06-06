//Programmer: John R. Adams
//Date: 06-06-2019
//
//EXERCISE:

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

//1.) Make the Employee class take a generic type parameter.

//2.) Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

//3.) Instantiate an Employee object with type "string" as its generic parameter

//4.) Assign a list of strings as the property value of Things.

//5.) Instantiate an Employee object with type "int" as its generic parameter.

//6.) Assign a list of integers as the property value of Things.

//7.) Create a loop that prints all of the Things to the Console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeThings
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>();
            employee1.Things.Add("time-travel device");
            employee1.Things.Add("time-travel disguise");
            employee1.Things.Add("language interpreter");
            employee1.Things.Add("Mobile Artificial Intelligence Device (M.A.I.D)");
            employee1.Things.Add("Time combat utility belt");

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>();
            employee2.Things.Add(1215);
            employee2.Things.Add(1776);
            employee2.Things.Add(1989);

            Console.WriteLine("These are the items that a new Time Bureau Recruit is issued for service in the Time Bureau: \n ");

            foreach(string thing in employee1.Things)
            {
                index = employee1.Things.FindIndex(a => a.Contains(thing));
                Console.WriteLine(employee1.Things[index]);       
            }
            Console.WriteLine();

            Console.WriteLine("These are the dates for the time anamolies left by the rogue Time Bureau Agent: ");
            for (int i = 0; i < employee2.Things.Count; i++)
            {
                Console.WriteLine(employee2.Things[i]);
            }

            Console.WriteLine("The first time anamoly is in the year {0} when the Magna Carta was supposed to be signed, seeding the ideals of modern democracy in the Western World.", employee2.Things[0]);
            Console.WriteLine("The second time anamoly occurs in the year {0} when the U.S. was supposed to declare its Independence.", employee2.Things[1]);
            Console.WriteLine("The last time anamoly occurs in the {0} when Tim Berners-Lee was supposed to invent the World Wide Web.", employee2.Things[2]);
            Console.WriteLine();
            Console.WriteLine("Your task is to fix the time anamolies and find the rogue Time Bureau Agent.");
            Console.WriteLine("Safe journey, and welcome to the Time Bureau New Recruit.  Word of advice, invest in the company pension.");
            Console.WriteLine("Before you know it, you have run out of time, and it is time for retirement...");
            Console.WriteLine("Or you die horribly on the job.  Whichever comes first.");
            Console.WriteLine("Now, go fix time.");
            Console.ReadLine();
             


        }
    }
}
