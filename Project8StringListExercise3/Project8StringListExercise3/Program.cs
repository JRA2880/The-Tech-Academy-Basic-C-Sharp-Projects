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

    class Program
    {
        static void Main()
        {
            List<string> creatureList = new List<string>() { "minotaur", "dragon", "kraken", "cyclops", "amarok", "camazotz", "gogmagog", "hecatoncheires", "ogopogo", "minotaur" };
            List<string> duplicateCheck = new List<string>();

            foreach (string creature in creatureList)
        { 
            if (!duplicateCheck.Contains(creature))
            {
                Console.WriteLine(creature + " - has not appeared in the list.");
            }
            else
            {
                Console.WriteLine(creature + " - has already appeared on the list.");
            }
            duplicateCheck.Add(creature);
        }





        ////for (i = 0; i < creatureList.Count; i++)
        //{
        //    Console.WriteLine(creatureList[i]);
        //}







        //int index;
        //index = creatureList.FindIndex(a => a.Contains(item));


        //foreach (string item in creatureList)
        //    {
        //    index = creatureList.FindIndex(a => a.Contains(item));

        //if (index <= 0)
        //{


        //    Console.WriteLine("Creature {0} appears on the list.", item);
        //}
        //else 
        //{
        //    Console.WriteLine("Creature {0} does not appear on the list.", item);
        //}
    }

    }
    
