//Programmer: John R. Adams
//Date: 06-04-2019

//PROGRAMMING EXERCISE: 

//In a CONSOLE APP create code that does the following:

//Program 1:

//1.) Create a one-dimensional Array of strings. 
//
//2.) Ask the user to input some text. 
//
//3.) Create a loop that goes through each string in the Array, adding the user’s text to the string. 
//
//4.) Then create a loop that prints off each string in the Array on a separate line.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1_StringArray
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "noo", "boo", "woo", "soo", "loo","foo","koo","mau","sau","gau","lau" };
            string input;

            Console.WriteLine("Type in some letters to create a new word... >> ");
            input = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + input;
                Console.WriteLine("By adding " + input + " you created the word " + stringArray[i]);
            }
            Console.ReadLine();
        }
    }
}

