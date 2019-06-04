//Programmer: John R. Adams
//Date: 06-04-2019

//PROGRAMMING EXERCISE:
//
// Program 2:
//
//In a console app, create code that does the following:
//
//1.) Create an infinite loop 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2_InfiniteLoopError
{
    class Program
    {
        static void Main()
        {
            const int MAX = 50; //This creates a max value in which the the for is supposed to reach to end the loop.
            int i; //This the counter variable which will intialize the loop and count through the loop

            for (i = 0; i < MAX; i--) { //Setting the count to a negative number is what creates the infinite loop because i can never reach the value of MAX.  
                Console.WriteLine("This program creates an infite loop..."); 
                Console.WriteLine(" Value: {0} ", i);//This displays the value of i so that the user can see the infinite loop in action.
            }
        }
    }
}
