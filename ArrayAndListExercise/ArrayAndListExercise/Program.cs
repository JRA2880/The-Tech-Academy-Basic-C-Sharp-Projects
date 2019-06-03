//Programmer: John R. Adams
//Date: 06 -03 -2019

//PROGRAMMING EXERCISE:

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

//1.) Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

//2.) Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

//3.) Add in a message that displays when the user selects an index that doesn’t exist.

//4.) Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

//Pseudocode:

//1.) Inside the main function, create a string array that stores the following strings {"Guantlet","Final Fantasy","Dragon's Lair","Castlevania","Metroid"}
//2.) Inside the main function, create an interger array that stores the following numbers {23, 52, 12, 15, 20 }
//3.) Inside the main function, create a string list that stores the following strings ("Megaman","Pacman","Kid Icarus","Link","Bowser")
//4.) Display to the screen the following output: "Welcome to the Array and List Exercise"
//5.) Display to the screen the following output: To display a classic game from the first array, enter an index number for the array to display the title of a classic game >> 
//6.) if input <= classicVideoGameArray.Length { ConsoleWriteLine(classicVideoGameArray[input];}
//7.) else {Console.WriteLine("Sorry, there is no {0} index in the array.  Please try again.);}
//8.) Display to the screen the following input: To display a number from the number array, enter a number >> 
//9.) if input <= numberArray.Length {ConsoleWriteLine("numberArray[input]");}
//10.) else {Console.WriteLine("Sorry, there is no {0} index in the array.  Please try again.);}
//11.) Display to the screen the following input: To display a classic video game character from the video game character list enter  an index number >>
//12.) if input <= vgCharacter.Length {ConsoleWriteLine("vgCharacter[input]");}
//13.) else {Console.WriteLine("Sorry, there is no {0} index in the list.  Please try again.);}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListExercise
{
    class Program
    {
        static void Main()
        {
            string[] classicVideoGames = { "Guanlet", "Final Fantasy", "Dragon's Lair", "Castlevania", "Metroid" };
            int[] numberArray = {23,52,12,15,20 };
            List<string> vgCharacters = new List<string>() {"Megaman","Pacman","Kid Icarus","Link","Bowser" };
            string input;
            int i;
            int j;
            int k;

            Console.WriteLine("Welcome to the Array and List Exercise!");
            Console.WriteLine();
            Console.WriteLine("To display a classic video game from the Classic Video Game Array...");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please enter a number to display a classic video game title >> ");
            input = Console.ReadLine();
            i = Convert.ToInt32(input);
            if( i < classicVideoGames.Length)
            {
                Console.WriteLine("The name of the classic video game at {0} is " + classicVideoGames[i] + ".",i);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sorry, that number doesn't exist in the array.");
                Console.WriteLine("Please try again.");
            }
            Console.WriteLine();
            Console.WriteLine("To display a number from the number Array...");
            Console.WriteLine("Please enter a number to choose an index in the array: ");
            Console.WriteLine();
            Console.Write("Please enter a number to display a number in the number array >> ");
            input = Console.ReadLine();
            j = Convert.ToInt32(input);
            if (j < numberArray.Length)
            {
                Console.WriteLine("The number at {0} is " + numberArray[j] + ".", j);
            }
            else
            {
                Console.WriteLine("Sorry, that number doesn't exist in the array.");
                Console.WriteLine("Please try again.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("To display a famous video game character from the video game character list...");
            Console.WriteLine();
            Console.Write("Please enter a number to display a famous video game character from the list >> ");
            input = Console.ReadLine();
            k = Convert.ToInt32(input);
            if (k <= 5)
            {
                Console.WriteLine("The famous video game character at index {0} is " + vgCharacters[k],k);

            }
            else
            {
                Console.WriteLine("Sorry, that number doesn't exist in the list.");
                Console.WriteLine("Please try again.");
            }
        }
    }
}
