using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number >> ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number >> ");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number >> ");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number >> ");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, you are wrong.");
                        Console.WriteLine("Guess a number >> ");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                }
            }
            while (!isGuessed);
   
            Console.Read();
        }
    }
}
