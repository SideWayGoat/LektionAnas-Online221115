using System;
using System.Collections.Generic;
using System.Text;

namespace LektionAnas_Online221115
{
    public partial class PartialCustomer
    {
        public void DisplayFullName()
        {
            Console.WriteLine("Full Name is : {0} {1} ", _firstName, _lastName);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Customer Details:\n{ID}\n{Email}\n{FirstName}\n{LastName}");
        }
    }
}
