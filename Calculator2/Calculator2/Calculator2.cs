using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator2
    {
        public Calculator2(int a, int b)
        {
            Function(a, b);
        }
        public void Function (int a, int b)
        {
            int c = (a * a) + (a + a) * a / (a * a) + (a + a) * a;
            Console.WriteLine(c);
            Console.WriteLine(b);
        }

    }
}
