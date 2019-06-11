using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearBornChecker
{
    public class InvalidYearException : Exception
    {
        public InvalidYearException() : base()
        {
        }
        public InvalidYearException(string message): base(message)
        {
        }
    }
}
