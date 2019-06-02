//Programmer: John R. Adams
//Date: 06-02-2019

//Program Purpose: The purpose of this program is to create a daily report interface for students to send in a daily report.
//The Program will be required to do the following:
//
//1.) The program must start by printing “The Tech Academy”.

//2.) The next line below that must be “Student Daily Report”

//3.) You must ask and save to a well-named variable and proper data type answers to the following questions:

//4.) What course are you on?

//5.) What page number?

//6.) Do you need help with anything? Please answer “true” or “false”.

//7.) Were there any positive experiences you’d like to share? Please give specifics.

//8.) How many hours did you study today?

//9.) After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This would be the end of the program.

//Pseudocode:

//   --Start Program--
//
//1.) Display to the screen the following output The Tech Academy

//2.) Display to the screen Student Daily Report

//3.) In Main function, declare the following variables:
//  a.) string currentCourse
//  b.) int pageNumber
//  c.) bool needHelp
//  d.) string positive Experience
//  e.) int studyHours
//4.)  Request from the user the following: "What current course are you on?
//5.)  Request from the user the following: What page are you on?
//6.)  Request from the user the following: Where there any positive experiences you would like to share? Please give specifics.
//7.)  Request from the user the following: How many hours did you study?
//8.)  Display the following output to the screen:
//     a.) Thank you for your Answers
//     b.) An instructor will respond to this shortly.
//     c.) Have a great day!
//
//   --End Program--

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Academy_Daily_Student_Report
{
    class Program
    {
        static void Main()
        {
            string input;
            string currentCourse;
            int pageNumber;
            bool needHelp = false;
            string positiveExperience;
            int studyHours;

            Console.WriteLine("\t<<  -- The Tech Academy -->> Learn to Code Anywhere!\n");
            Console.WriteLine("\t<<-- Daily Student Report -->> \n");

            Console.Write("What course are you on currently on? >> ");
            currentCourse = Console.ReadLine();

            Console.Write("What page are you on? Please only enter a number >> ");
            input = Console.ReadLine();
            pageNumber = Convert.ToInt32(input);

            Console.Write("Do you need any help? Please answer true or false >> ");
            input = Console.ReadLine();
            needHelp = Convert.ToBoolean(input);
           

            Console.WriteLine("Where there any positive experiences You would like to share? Please be specific >> \n");
            positiveExperience = Console.ReadLine();
            Console.WriteLine();
            Console.Write("How many hours did you study today? >> ");
            input = Console.ReadLine();
            studyHours = Convert.ToInt32(input);
            Console.WriteLine();
            Console.WriteLine("You are currently on the " + currentCourse);
            Console.WriteLine("You are on page " + pageNumber);
            Console.WriteLine("You studied for " + studyHours + " hour(s) today");
            if (needHelp == true) {
                Console.WriteLine("You said it is true that you need some help.  We will get an Instructor to get in touch ASAP!");
            }
            else
            {
                Console.WriteLine("You said you don't need any help right now.  We are really glad you are doing well in the program!");
            }
            Console.WriteLine("This is the positive experience you wrote about today: " + positiveExperience);
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers");
            Console.WriteLine();
            Console.WriteLine("An instructor will respond to this shortly.");
            Console.WriteLine();
            Console.WriteLine("Have a great day!");
            Console.ReadLine();
        }
    }
}



