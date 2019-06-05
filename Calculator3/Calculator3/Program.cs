//Programmer: John R. Adams
//Date: 06-06-2019
//
//Programming Exercise:
//
//1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.

//2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.

//3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.

//4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.

//5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.

//6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator3 calculator = new Calculator3();

            int q = calculator.Function(12);
            Console.WriteLine(q);
            Console.WriteLine();
            double p = calculator.Function(12.6789);
            Console.WriteLine(p);
            Console.WriteLine();
            int r = calculator.Function("13");
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
