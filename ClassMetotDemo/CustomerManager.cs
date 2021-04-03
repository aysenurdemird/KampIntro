using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Congratulations, " + customer.Name + " " + customer.Surname + ". Your registration is completed.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("We are sorry for that, " + customer.Name + " " + customer.Surname + ". Your registration has been deleted. We hope to see you again.");
        }
        
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
            }

            Console.WriteLine("Customers listed.");

        }
        
    }
}
