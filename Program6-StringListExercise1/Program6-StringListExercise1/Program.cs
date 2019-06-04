//Programmer: John R. Adams
//Date: 06-04-2019
//
//Program 6: Programming Exercise
//
//In a console app, create code that does the following:
//
//1.) Create a List of strings where each item in the list is unique. 
//2.) Ask the user to select text to search for in the List. 
//3.) Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
//4.) Add code to that above loop that tells a user if they put in text that isn’t in the List.
//5.) Add code to that above loop that stops it from executing once a match has been found.

//Pseudocode:
//1.) Inside the MAIN function, declare the following:
//2.) string listItem;
//3.) List<str> sandwichList = new List(){"potato chips","soda","tomatoes","onions","lettuce","cheese","ketchup","mayo","mustard","bread","pickles"};
//4.) Inside the MAIN function, display to the screen, the following: "Hello, please enter an item that you think is on the sandwich list >> "
//5.) listItem = Console.ReadLine();
//6.) if listItem if (sandwichList.Contains(listItem))
//7.) Then display to the user the following text: "Sorry that item is not on the sandwich list"  Please try again.
//8.) Else 
//9.) foreach (string listItem in sandwichList) {
//      Console.WriteLine("The index of item {0} is {1}",listItem,listItem.FindIndex(listItem));
//      break;
//    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6_StringListExercise1
{
    class Program
    {
        static void Main()
        {
            List<string> sandwichList = new List<string>() {"potato chips","soda","tomatoes","onions","lettuce", "deli meats","cheese","ketchup","mayonnaise","mustard","bread","pickles" };
            string listItem;
            int index;
            Console.Write("Please enter an item that is on the sandwich list >> ");
            listItem = Console.ReadLine();

            if (sandwichList.Contains(listItem))
            {
                foreach (string listitem in sandwichList)
                {
                    Console.WriteLine("{0} is on the sandwich list.", listItem);
                    index = sandwichList.FindIndex(a => a.Contains(listItem));
                    Console.WriteLine("The place of {0} on the list is at index {1}.", listItem, index);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Sorry, that item is not on the sandwich list.  Please try another item.");
                Console.Write("Please enter an item that is on the sandwich list >> ");
                listItem = Console.ReadLine();
                if (sandwichList.Contains(listItem))
                {
                    foreach (string listitem in sandwichList)
                    {
                        Console.WriteLine("{0} is on the sandwich list.", listItem);
                        index = sandwichList.FindIndex(a => a.Contains(listItem));
                        Console.WriteLine("The place of {0} on the list is at index {1}.", listItem, index);
                        break;
                    }
                }
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
