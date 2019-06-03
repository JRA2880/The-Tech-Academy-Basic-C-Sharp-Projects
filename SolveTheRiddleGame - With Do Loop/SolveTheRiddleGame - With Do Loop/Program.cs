//Programmer: John R. Adams
//Date: 06-03-2019

//Program Purpose: To create a program that uses a do/while loop and a boolean comparison value to enter and break the loop.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTheRiddleGame___With_Do_Loop
{
    class Program
    {
        static void Main()
        {
            string input;
            int number;
            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
            Console.WriteLine("How many were going to St. Ives?");
            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            bool answer = number == 1;
            do {
                    switch (number)
                    {
                        case 7:
                            Console.WriteLine("You guessed 7.  Sorry that is not the answer.");
                            Console.WriteLine("Read the riddle one more time...");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
                            input = Console.ReadLine();
                            number = Convert.ToInt32(input);
                            break;
                        case 6:
                            Console.WriteLine("You guessed 6.  Sorry that is not the answer.");
                            Console.WriteLine("Read the riddle one more time...");
                            Console.WriteLine("Pay attention closely, exactly who is going to St.Ives...");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
                            input = Console.ReadLine();
                            number = Convert.ToInt32(input);
                            break;
                        case 5:
                            Console.WriteLine("You guessed 5.  Sorry that is not the answer.");
                            Console.WriteLine("Read the riddle one more time...");
                            Console.WriteLine("Pay attention to the 7 wives, 7 sacks, and 7 cats...");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
                            input = Console.ReadLine();
                            number = Convert.ToInt32(input);
                            break;
                        case 4:
                            Console.WriteLine("You guessed 4.  Sorry that is not the answer.");
                            Console.WriteLine("Read the riddle one more time...");
                            Console.WriteLine("Pay attention to the 7 wives, 7 sacks, 7 cats and 7 kittens...");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
                            input = Console.ReadLine();
                            number = Convert.ToInt32(input);
                            break;
                        case 3:
                            Console.WriteLine("You guessed 3.  Sorry that is not the answer.");
                            Console.WriteLine("Read the riddle one more time...");
                            Console.WriteLine("Pay attention to the 7 wives, 7 sacks, 7 cats and 7 kittens...and who is going to St.Ives?");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
                            input = Console.ReadLine();
                            number = Convert.ToInt32(input);
                            break;
                        case 2:
                            Console.WriteLine("You guessed 2.  Sorry that is not the answer....but you are close...");
                            Console.WriteLine("Read the riddle one more time...");
                            Console.WriteLine("Pay attention to the 7 wives, 7 sacks, 7 cats and 7 kittens...and who is going to St.Ives?");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
                            input = Console.ReadLine();
                            number = Convert.ToInt32(input);
                            break;
                        case 1:
                            Console.WriteLine("You guessed 1.  That is correct!");
                            Console.WriteLine("As you deduced in the riddle....");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("One. the person who saw the man with 7 wives who each had 7 sacks, filled with 7 cats, each with 7 kittens.");
                            Console.WriteLine("Congratulations! You solved the riddle!");
                            answer = true;
                            break;
                        default:
                            Console.WriteLine("Sorry, your guess is incorrect.");
                            Console.WriteLine("Read the riddle one more time...");
                            Console.WriteLine("On my way to St. Ives I saw a man with 7 wives.");
                            Console.WriteLine("Each wife had 7 sacks. Each sack had 7 cats.");
                            Console.WriteLine("Each cat had 7 kittens. Kitten, cats, sacks, wives.");
                            Console.WriteLine("How many were going to St. Ives?");
                            Console.WriteLine("Enter a number to guess how many were going to St.Ives >> ");
                            input = Console.ReadLine();
                            number = Convert.ToInt32(input);
                            break;
                    }
            }
            while (!answer);
        }
    }
}
