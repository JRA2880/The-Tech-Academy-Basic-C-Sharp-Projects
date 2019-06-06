using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator5
{
    public class Calculator
    {
        public void Function(int a)
        {
            int b = a / 2;
            Console.WriteLine("The number you entered divided by 2 equals: " + b);
        }
        public int Function(int a, int b, out int area)
        {
            area = a * b;
            return area;
        }
        public string Function(string a)
        {
            string b = "is the King of the North!";
            string c = a + " " + b;
            return c;
        }
    }
}
