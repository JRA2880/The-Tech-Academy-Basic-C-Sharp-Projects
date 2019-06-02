using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.WriteLine("Twelve plus Twenty-Two = " + otherTotal.ToString());
            //Console.WriteLine("The combined total = " + combined.ToString());

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());

            //int product = 10 * 5;
            //Console.WriteLine("The product of 10 multiplied by Five = " + product.ToString());

            //int quotient = 100 / 5;
            //Console.WriteLine("One hundred divided by Five = " + quotient.ToString());

            //int remainder = 11 % 2;
            //Console.WriteLine("The remainder of Ten divided by Two =  " + remainder);

            //bool trueOrFalse = 5 > 12;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
