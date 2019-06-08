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

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
}    }
