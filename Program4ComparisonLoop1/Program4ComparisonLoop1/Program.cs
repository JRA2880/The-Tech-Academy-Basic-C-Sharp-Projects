//Programmer: John R. Adams
//Date: 06-04-2019
//
//Program 4: Programming Exercise
//
//In a console app, create code that does the following:
//
//1.) Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4ComparisonLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarvesArray = { "Dopey", "Sleepy", "Sneezy", "Happy", "Grumpy", "Bashful", "Doc" };
            int i;

            Console.WriteLine("Can you name all of the seven dwarves from Snow White and the Seven Dwarves? \n");
            Console.WriteLine("Here is a list to help you out! \n");
            Console.WriteLine("Well...");
            Console.WriteLine();

            for (i = 0; i < sevenDwarvesArray.Length; i++)
            {
                Console.WriteLine("There is {0}.",sevenDwarvesArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("And that is all the seven dwarves from the tale!");
            Console.WriteLine();
        }
    }
}
