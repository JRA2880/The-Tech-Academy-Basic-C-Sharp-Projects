//Course  Notes:
//List<Game> games = new List<Game>();
//Game game = new TwentyOneGame();
//games.Add(game);
//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
//game.ListPlayers();
//Console.ReadLine();
//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Jesse";
//game += player;
//game -= player;
//Card card1 = new Card();
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;
//Console.WriteLine(card1.Face);
//int count = deck.Cards.Count(x => x.Face == Face.Ace);
//Console.WriteLine("The number of Aces in the Deck are: " + count);
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}
//List<int> numberList = new List<int>() { 1, 2, 3, 4, 5,12,145,535 } ;
//int sum = numberList.Where(x => x > 20).Sum();
//Console.WriteLine(sum);
//foreach (Card card in deck.Cards)
//{
//    if (card.Face == Face.Ace)
//    {
//        counter++;
//    }
//}
//Console.WriteLine("The number of Aces in the deck are: " + counter);


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Cansino. Let's start by telling me your name >> ");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today? ");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now? >> ",playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yup")
            {
                Player player = new Player(playerName,bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.Read();
        }
}    }
