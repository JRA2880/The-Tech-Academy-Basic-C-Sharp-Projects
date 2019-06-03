using System;
using static System.String;
using System.Text;


namespace StringFunctions
{
    class Program
    {
        static void Main()
        {
            //string name = "Jesse";

            //string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n\tHello on a tab";
            //Console.WriteLine(quote);
            //string fileName = @"C:\Users\John";
            //Console.WriteLine(fileName);

            //bool trueOrFalse = name.Contains("s");
            //Console.WriteLine(trueOrFalse);

            //trueOrFalse = name.EndsWith("s");
            //Console.WriteLine(trueOrFalse);
            //int length = name.Length;
            //Console.WriteLine(length);

            //name = name.ToUpper();
            //Console.WriteLine(name);
            //name = name.ToLower();
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");
            Console.WriteLine(sb);


        }
    }
}
