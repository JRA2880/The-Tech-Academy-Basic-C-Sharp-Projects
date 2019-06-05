using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{   
    class Calculator3
    {
      
        public int Function(int a)
        {
            int b = (a * a) / a;
            return b;
        }
        public double Function(double a)
        {
            double b = (a + a) * a;
            return b;
        }
        public int Function(string a)
        {
            int b = Convert.ToInt32(a);
            int c = (b * b) / b;
            return c;
        }
    }
}
