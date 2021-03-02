using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotCustomerT
{
    class CustomerManager
    {
        Customer[] customers = new Customer[100];
        int counter = 0;

        public int AddCustomer(string ID, string surname, string phoneNumber)
        {
            int final = -1;
            if(counter < 100)
            {
                customers[counter] = new Customer();
                customers[counter].ID = ID;
                customers[counter].surname = surname;
                customers[counter].phoneNumber = phoneNumber;
                counter++;
                final = 1;
            }
            return final;
        }

        public int FindCustomer(string ID)
        {
            int index = -1;
            for (int i=0; (i<counter); i++)
            {
                if (customers[i].ID == ID)
                {
                    index = 1;
                }
            }
            return index; 
        }

        public int DeleteCustomer(string ID)
        {
            int index = FindCustomer(ID);
            if(index != -1)
            {
                for (int i = index ; (i < counter -1); i++)
                {
                    customers[i].ID = customers[i + 1].ID;
                    customers[i].surname = customers[i + 1].surname;
                    customers[i].phoneNumber = customers[i + 1].phoneNumber;
                }
                counter--;
            }
            return index;
        }

        public string List()
        {
            string output = "";
            for(int i=0; i< counter; i++)          
                output += customers[i].FormatInformation() + "\n";
            return output;          
        }


    }

}
