using Casino.TwentyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Cansino. Let's start by telling me your name >> ");
            string playerName = Console.ReadLine();
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("Please digits only, decimals >> ");
                }
            }
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now? >> ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yup")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\johnr\myProjects\The-Tech-Academy-Basic-C-Sharp-Projects\TwentyOne\log.txt", true))
                {
                   file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {  
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred.  Please contact your System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.Read();
        }
    }
}
