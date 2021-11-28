using CodePatterns_U1.Interfaces;
using System;
using System.Collections.Generic;

namespace CodePatterns_U1.Services
{
    public class Customers : ICustomers
    {
        public static List<ICustomer> CustomerList;

        public void Register()
        {
            Console.Clear();

            ICustomer customer = Factory.CreateICustomer();

            Console.WriteLine("Name of customer:");
            customer.Name = Console.ReadLine();

            Console.WriteLine("Phone number:");
            customer.PhoneNumber = Console.ReadLine();

            CustomerList.Add(customer);
        }
    }
}