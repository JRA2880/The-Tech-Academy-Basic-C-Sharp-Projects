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

                foreach (string listitem in groceryList )
                {  
                    index = groceryList.FindIndex(a => a.Contains(listitem));
                    Console.WriteLine(listitem + " " + index);
                    
                
                }
        }
    }
}

