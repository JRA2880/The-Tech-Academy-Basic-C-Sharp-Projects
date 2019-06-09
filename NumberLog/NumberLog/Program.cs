//Programmer: John R. Adams
//Date: 06-03-2019
//
//EXERCISE:
//
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//
//1.) Ask a user for a number.

//2.) Log that number to a text file.

//3.) Print the text file back to the user.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberLog
{
    class Program
    {
        static void Main(string[] args)
        {
            const int QUIT = -1;
            string input;
            int number;
            
            Console.WriteLine("Please enter a number into the log or press -1 to quit. \n");
            input = Console.ReadLine();
            Console.WriteLine();
            number = Convert.ToInt32(input);

            while (number != QUIT)
            {
                Console.Write("Please enter a number to recorded to the log >> ");
                input = Console.ReadLine();
                number = Convert.ToInt32(input);
                using (StreamWriter writeNumber = new StreamWriter(@"C:\Users\johnr\myProjects\The-Tech-Academy-Basic-C-Sharp-Projects\NumberLog\logfile.txt",true))
                {
                    writeNumber.WriteLine("Log: {0}", number);
                }
            }
            StreamReader readText = new StreamReader(@"C:\Users\johnr\myProjects\The-Tech-Academy-Basic-C-Sharp-Projects\NumberLog\logfile.txt");
            string line = readText.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = readText.ReadLine();
            }
            readText.Close();
            Console.ReadLine();
        }
    }
}
