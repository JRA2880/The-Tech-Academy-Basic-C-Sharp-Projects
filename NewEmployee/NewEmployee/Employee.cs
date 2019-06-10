using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployee
{
    public class Employee : Person
    {
        public Employee(string firstname,string lastname ) : this(firstname,lastname,1,100.00)
        {
        }
        public Employee (string firstname, string lastname,int ID,double balance)
        {
            fName = firstname;
            lName = lastname;
            EmployeeId = ID;
            EmployeeBalance = balance;
        }
        public int EmployeeId { get; set; }
        public double EmployeeBalance { get; set; }

        public void HelloNewEmployee(Employee employee)
        {
            Console.WriteLine("First Name:  {0}", employee.fName);
            Console.WriteLine("Last  Name:  {0}", employee.lName);
            Console.WriteLine("Employee ID: {0}", employee.EmployeeId);
            Console.WriteLine("Balance:     {0}", employee.EmployeeBalance);
        }
    }
}
