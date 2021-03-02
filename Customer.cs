using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotCustomerT
{
    class Customer
    {
        public string ID;
        public string surname;
        public string phoneNumber;

        public string FormatInformation()
        {
            string output = "ID: " + ID + "Surname: " + surname + "Phone Number: " + phoneNumber;
            return output;
        }
    }
}
