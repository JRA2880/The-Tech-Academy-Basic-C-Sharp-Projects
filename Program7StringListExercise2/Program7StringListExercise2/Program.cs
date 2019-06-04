//Programmer: John R. Adams
//Date: 06-04-2019
//
//Program 7: Programming Exercise
//
//In a console app, create code that does the following:
//
//1.) Create List of strings that has a at least two identical strings in the List
//2.) Ask the user to select text to search for in the List. 
//3.) Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
//4.) Add code to that above loop that tells a user if they put in text that isn’t in the List.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7StringListExercise2
{
    class Program
    {
        static void Main()
        {
            List<string> groceryList = new List<string>() { "potatoes", "milk", "tomatoes", "onions", "lettuce", "sweet potatoes", "flour", "ramen noodles", "cheese", "soda", "potatoes" };
            string listItem;
            int index;

            Console.WriteLine("Please enter a list item to display the grocery list item and their indexes >>");
            listItem = Console.ReadLine();
            if (groceryList.Contains(listItem))
            {
                foreach (string item in groceryList)
                {
                    index = groceryList.FindIndex(a => a.Contains(item));
                    if (index >= 0)
                    {
                        Console.WriteLine(item + " " + index);
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry {0} is not on the list.", listItem);
            }

                
            
        }
    }
}

