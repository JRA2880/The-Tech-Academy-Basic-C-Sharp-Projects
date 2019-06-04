//Programmer: John R. Adams
//Date: 06-04-2019
//
//Program 3 Programming Excercise:
//
// In a console app, create code that does the following:
//
//1.) Fix the infinite loop so that it will execute.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3_InfiniteLoopErrorFixed
{
    class Program
    {
            static void Main()
            {
                const int MAX = 50; //This creates a max value in which the the for is supposed to reach to end the loop.
                int i; //This the counter variable which will intialize the loop and count through the loop

                for (i = 0; i < MAX; i++) //Setting the count to an positive incremental count allows the loop to loop through and reach the value of MAX as intended.  
                { 
                    Console.WriteLine(" Value: {0} ", i); //This allows the user to see the for loop in action.
                }
            }
        
    }
}
    

