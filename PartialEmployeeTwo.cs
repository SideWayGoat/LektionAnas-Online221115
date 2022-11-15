using System;
using System.Collections.Generic;
using System.Text;

namespace LektionAnas_Online221115
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine(@"Full Name is : {0} {1} ", _firstName, _lastName);
        }

        public void DisplayEmployeeData()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine("First Name: {0}", _firstName);
            Console.WriteLine("Last Name: {0} ", _lastName);
            Console.WriteLine("Salary: {0:C}", _salary);
        }
    }
}
