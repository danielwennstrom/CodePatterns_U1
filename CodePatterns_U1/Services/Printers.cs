using CodePatterns_U1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodePatterns_U1.Services
{
    internal class Printers : IPrinters
    {
        public string IAnimalPrinter(IAnimal obj)
        {
            string status = obj.IsInKennel ? "In Kennel" : "Retrieved";
            string owner = string.IsNullOrEmpty(obj.Owner?.Name) ? "Unassigned" : obj.Owner.Name;
            StringBuilder services = new();

            if (obj.ExtraServices?.Count > 0)
            {
                foreach (var service in obj.ExtraServices)
                {
                    services.Append($"{service.ServiceTitle} ");
                }
            }
            else
            {
                services.Append("No extra services");
            }

            return $"Id: {obj.Id}, Name: {obj.Name}, Species: {obj.Species}, Breed: {obj.Breed}, Status: {status}, Owner: {owner}, Services: {services}";
        }

        public void IAnimalsByIdPrinter(List<ICustomer> list)
        {
            ICustomer customer;
            IParser parser = Factory.CreateIParser();
            IFinders finder = Factory.CreateIFinders();

            Console.Clear();

            ICustomersPrinter(list);

            Console.WriteLine("Please enter ID of customer: ");
            customer = finder.FindById(list, parser.ParseId(Console.ReadLine()));

            if (customer != null)
            {
                IAnimalsPrinter(customer.Animals);
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
        }

        public void IAnimalsInKennelPrinter(List<IAnimal> list)
        {
            Console.Clear();

            var animalsInKennel = list.Where(a => a.IsInKennel);

            if (animalsInKennel.Count() > 0)
            {
                foreach (var animal in animalsInKennel)
                {
                    Console.WriteLine(IAnimalPrinter(animal));
                }
            }
            else
            {
                Console.WriteLine("No animals registered.");
            }
        }

        public void IAnimalsPrinter(List<IAnimal> list)
        {
            Console.Clear();

            if (list.Count > 0)
            {
                foreach (var animal in list)
                {
                    Console.WriteLine(IAnimalPrinter(animal));
                }
            }
            else
            {
                Console.WriteLine("No animals registered.");
            }
        }

        public string ICustomerPrinter(ICustomer obj)
        {
            return $"Id: {obj.Id}, Name: {obj.Name}, Phone Number: {obj.PhoneNumber}";
        }

        public void ICustomersPrinter(List<ICustomer> list)
        {
            Console.Clear();

            if (list.Count > 0)
            {
                foreach (var customer in list)
                {
                    Console.WriteLine(ICustomerPrinter(customer));
                }
            }
            else
            {
                Console.WriteLine("No customers registered.");
            }
        }

        public void IExtraServicesPrinter(List<IExtraService> extraServices)
        {
            foreach (var service in extraServices)
            {
                Console.WriteLine($"{service.ServiceTitle}");
            }
        }

        public void ReceiptPrinter()
        {
            IFinders finder = Factory.CreateIFinders();
            ITally tally = Factory.CreateITally();
            IParser parser = Factory.CreateIParser();
            ICustomer selectedCustomer;
            dynamic totalCost = 0;

            ICustomersPrinter(Customers.CustomerList);

            Console.WriteLine("Please enter ID of customer: ");
            selectedCustomer = finder.FindById(Customers.CustomerList, parser.ParseId(Console.ReadLine()));

            if (selectedCustomer != null)
            {
                foreach (var animal in selectedCustomer.Animals)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"{animal.Name}");
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"Base cost: {tally.TallyBaseCost(animal)} SEK");

                    if (animal.ExtraServices.Count > 0)
                    {
                        Console.WriteLine($"Extra services:");
                        foreach (var service in animal.ExtraServices)
                        {
                            Console.WriteLine($"{service.ServiceTitle} {service.ServiceCost} SEK");
                        }
                    }

                    totalCost = totalCost + tally.TallyBaseCost(animal) + tally.TallyExtraServicesCost(animal);
                }
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Total cost: {totalCost} SEK");
        }
    }
}