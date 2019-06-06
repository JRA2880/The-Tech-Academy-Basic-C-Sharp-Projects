using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePersonClass
{
    class Employee : Person
    {
        public int Id { get; set; }
        
        public void EmployeeId()
        {
          Console.WriteLine("Employe ID #: [ {0} ]",Id);
        }
    }
}
