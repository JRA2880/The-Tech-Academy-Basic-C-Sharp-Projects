//Programmer: John R. Adams
//Date: 06-07-2019
//
//EXERCISE:

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1.)  Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

//2.) In the Main() method, create an object of data type Number and assign an amount to it.

//3.) Print this amount to the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        public struct Number
        {
            public double Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 3.14;
            Console.WriteLine("The number store in the object number amount will be familiar with anyone who likes Pi: " + number.Amount);
            Console.ReadLine();
        }
    }
}
