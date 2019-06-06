using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIDChecker
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool isEqual = false;

            if (employee1.ID == employee2.ID)
            {
                isEqual = true;
            }
            return isEqual;
            
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool isEqual = true;
            
            if (employee1.ID != employee2.ID)
            {
                isEqual = false;          
            }
            return isEqual;
        }


    }

}
