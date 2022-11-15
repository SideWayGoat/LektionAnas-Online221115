using System;
using System.Collections.Generic;
using System.Text;

namespace LektionAnas_Online221115
{
    public class Customer
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;



        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int ID { get => _id; set => _id = value; }

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
