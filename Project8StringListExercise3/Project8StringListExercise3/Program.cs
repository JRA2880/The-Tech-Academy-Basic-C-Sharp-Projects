//Programmer: John R. Adams
//Date: 06-04-2019
//
//Program 8: Programming Exercise
//
//REQUIREMENTS:
//
//1.) Create a List of strings that has at least two identical strings in the List. 
//2.) Create a foreach loop that evaluates each item in the list.
//3.) And displays a message showing the string and whether or not it has already appeared in the list.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8StringListExercise3
{
    class Program
    {
        static void Main()
        {
            List<string> creatureList = new List<string>() {"jabberwocky","minotaur","ogre","dragon","kraken","cyclops","amarok", "camazotz", "erymanthian boar", "gogmagog", "hecatoncheires", "ogopogo","minotaur","sansquatch","yeti","skunk ape","mothman"};
            string listItem;
            int index;

            Console.WriteLine("Please enter the name of a mythical creature to determine if it is on the creature list >> ");
            listItem = Console.ReadLine();
            Console.WriteLine();

            foreach(string item in creatureList)
            {   index = creatureList.FindIndex(a => a.Contains(listItem));
                if (index >= 0)
                {
                    Console.WriteLine("Creature {0} already appears on the creature list at index {1}.", listItem, index);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, creature {0} does not appear on the list.", listItem);
                    break;
                }
                    
            }
        }
    }
}
