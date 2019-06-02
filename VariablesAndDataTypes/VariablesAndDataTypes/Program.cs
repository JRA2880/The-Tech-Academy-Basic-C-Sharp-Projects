using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            ////This is a simple program
            //Console.WriteLine("what is your name? ");
            //string yourname = Console.ReadLine();
            //Console.WriteLine("hello " + yourname + " welcome to c# programming!");
            //Console.ReadLine();

            ////This is another simple program
            //Console.WriteLine("What is your favorite number? ");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.3223233;
            float secondsleft = 2.62f;
            short temperatureOnMars = -341;
            string myname = "George of the Jungle";

            int currentAge = 30;

            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();


        }
    }
}
