using System;

namespace ClassMetotCustomerT
{
    class Program
    {
        static void Main(string[] args)
        {
            //this program includes codes that show the customer organization of a bank 
            //allowing us to consolidate methods and Class concepts.

            CustomerManager manager = new CustomerManager();

            //adding
            manager.AddCustomer("1h2", "Yesilova", "7894");
            manager.AddCustomer("1k2", "Turak", "5644");
            manager.AddCustomer("1y2", "Demir", "9632");
            manager.AddCustomer("1t2", "Kaya", "8543");

            int index = manager.FindCustomer("1h2");
            Console.WriteLine(index);

            string list = manager.List();
            Console.WriteLine(list);

            //deletion
            int del = manager.DeleteCustomer("1k2");
            if (del == -1)
                Console.WriteLine("deletion failed");
            else
                Console.WriteLine("deletion successful:" + del);

            //after deletion
            string list2 = manager.List();
            Console.WriteLine(list2);
        }
    }
}
