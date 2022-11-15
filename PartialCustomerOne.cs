using System;
using System.Collections.Generic;
using System.Text;

namespace LektionAnas_Online221115
{
    public partial class PartialCustomer
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

    }
}
