//Programmer: John R. Adams
//Date: 06-03-2019

//PROGRAM EXERCISE:

//REQUIREMENTS: 
//1.) In a console app, create code that does the following: 
//2.) Convert a string to uppercase
//3.) Create a Stringbuilder and build a paragraph of text, one sentence at a time.
//4.) Concatenate three strings.

//PSEUDOCODE:
//1.) In the main function, declare the following variables:
// a.) verse 1;
// b.) verse 2;
// c.) verse 3;
// d.) verse 4;
// e.) verse 5;
// f.) verse 6;
// g.) verse 7;
// h.) verse 8;
// i.) verse 9;
// j.) verse 10;
// k.) verse 11;
// l.) verse 12;
// m.) verse 13;
// n.) verse 14;
// o.) verse 15;
// p.) verse 16;
//2.) Inside verse 1, store the following string = Hey Jude, don't make it bad...
//3.) Inside verse 2, store the following string = ...Take a sad song and make it better...
//4.) Inside verse 3, store the following string = Remember to let her into your heart...
//5.) Inside verse 4, store the following string = Then you can start to make it better.
//6.) Store the remainder of the verses of Hey Jude in variables verses 5 - 16.
//7.) Convert verse 16 to upper case to using the function ToUpper().
//8.) Declare the object StringBuilder remainingVerses = New StringBuilder();
//9.) Append the object StringBuilder remainingVerses using the function Append.
//10.) Each time a verse is appended to the remaining of the song Hey Jude, print it to the console.
//11.) Append the next verse using the Append Function to the object remainingVerses.
//12.) Then print out the next line.
//13.) Continue this until all the lyrics to the song have been displayed to the screen as output.







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyJude
{
    class Program
    {
        static void Main(string[] args)
        {
            string verse1, verse2, verse3, verse4, verse5, verse6, verse7, verse8, verse9, verse10, verse11, verse12, verse13, verse14, verse15, verse16, verse17, verse18, verse19, verse20;
            StringBuilder remainingVerses = new StringBuilder("So let it out and let in...");

            verse1 = "Hey Jude, don't make it bad...";
            verse2 = "Take a sad song and make it better...";
            verse3 = "Remember to let her into your heart...";
            verse4 = "Then you can make it better.";
            verse5 = "Hey Jude, don't be afraid...";
            verse6 = "You were made to go out and get her...";
            verse7 = "The minute you let her under your skin'...";
            verse8 = "Then you begin to make it better.";
            verse9 = "And anytime you feel the pain...";
            verse10 = "Hey Jude refrain...";
            verse11 = "Don't carry the world upon your shoulders...";
            verse12 = "For well you know that it's a fool...";
            verse13 = "Who plays it cool...";
            verse14 = "By making his world a little colder.";
            verse15 = "Na-na-na, na, na...";
            verse16 = "Na-na-na, na";
            verse17 = "Hey Jude, don't let me down...";
            verse18 = "You have found her, now go and get her (let it out and let it in)...";
            verse19 = "Remember to let her into your heart (hey Jude)...";
            verse20 = "Then you can start to make it better.";

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t   Hey Jude --- by The Beatles");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(verse1 + "\n" + verse2+ "\n" + verse3 + "\n" + verse4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(verse5 + "\n" + verse6 + "\n" + verse7 + "\n" + verse8);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(verse9 + "\n" + verse10 + "\n" + verse11 + "\n" + verse12 + "\n" + verse13 + "\n" + verse14);
            verse15 = verse15.ToUpper();
            verse16 = verse16.ToUpper();
            Console.WriteLine(verse15 + "\n" + verse16 + "\n");
            Console.WriteLine();
            Console.WriteLine(verse17 + "\n" + verse18 + "\n" + verse19 + "\n" + verse20);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(remainingVerses);
            Console.WriteLine();
            remainingVerses.Append("Hey Jude begin...");
            Console.WriteLine();
            Console.WriteLine(remainingVerses);
            remainingVerses.Append("You're waiting for someone to perform with...");
            Console.WriteLine(remainingVerses);
            remainingVerses.Append("And don't you know that it's just you...");
            Console.WriteLine();
            Console.WriteLine(remainingVerses);
            remainingVerses.Append("Hey Jude, you'll do...");
            Console.WriteLine();
            Console.WriteLine(remainingVerses);
            Console.WriteLine();
            remainingVerses.Append("The movement you need is on your shoulder...");
            Console.WriteLine(remainingVerses);
            Console.WriteLine();
            remainingVerses.Append("Na-na-na, na, na...Na - na - na, na, yeah");
            Console.WriteLine(remainingVerses);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
