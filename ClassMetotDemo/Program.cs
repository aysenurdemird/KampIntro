using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 875698;
            customer1.Name = "Sude";
            customer1.Surname = "Kaya";

            Customer customer2 = new Customer();
            customer2.Id = 987512;
            customer2.Name = "Hasan";
            customer2.Surname = "Avan";

            Customer customer3 = new Customer();
            customer3.Id = 157948;
            customer3.Name = "Cemile";
            customer3.Surname = "Bilgin";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.Delete(customer1);      
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.List(customers);


            //Console.WriteLine("Hello World!");
        }
    }
}
