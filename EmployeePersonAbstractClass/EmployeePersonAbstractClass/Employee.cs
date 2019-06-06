using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePersonAbstractClass
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("First Name: {0} ",firstName);
            Console.WriteLine("Last Name:  {0} ", lastName);
        }
    }
}
