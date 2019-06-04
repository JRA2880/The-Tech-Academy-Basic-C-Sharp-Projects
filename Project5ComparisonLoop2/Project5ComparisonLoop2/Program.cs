//Programmer: John R. Adams
//Date: 06-04-2019
//
//Program 5: Programming Exercise
//
//In a console app, create code that does the following:
//
//1.) Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5ComparisonLoop2
{
    class Program
    {
        static void Main()
        {
            string[] itemsArray = { "holy water", "stakes", "sun bomb", "holy cross", "vampire-fighting whip","decapitating sickle","garlic pizza","crossbow with wooden arrows" };
            double[] priceArray = { 1.99, 2.99, 299.99, 15.99, 99.99, 59.99, 9.99, 89.99 };
         
            string input;
            int i;

            Console.WriteLine("Welcome to the Vampire Hunter Mart! \n");
            Console.WriteLine("The #1 and only store in the world that vampires exist!");
            Console.WriteLine();
            Console.Write("Please enter a value between 0 and 4 to print out the item to the screen for purchase >> ");
            input = Console.ReadLine();
            i = Convert.ToInt32(input);

            while ( i <= 7)
            {
                Console.WriteLine("The item at index {0} is " + itemsArray[i], i);
                Console.WriteLine("The cost of item {0} is " + priceArray[i].ToString("C"), i);
                break;
            }
            if (i > 7)
            {
                Console.WriteLine("Sorry there is no item with a number like that in our inventory.  Please try again.");
            }
            Console.WriteLine("Don't Wait...buy your vampire hunting weapons against the scourge of the night while you still can!");
        }
    }
}
