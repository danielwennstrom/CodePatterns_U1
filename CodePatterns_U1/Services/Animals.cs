using CodePatterns_U1.Interfaces;
using System;
using System.Collections.Generic;

namespace CodePatterns_U1.Services
{
    public class Animals : IAnimals
    {
        public static List<IAnimal> AnimalList;

        public void Assign()
        {
            IAnimal selectedAnimal = null;
            ICustomer selectedCustomer = null;
            IParser parser = Factory.CreateIParser();
            IFinders finder = Factory.CreateIFinders();
            IPrinters printer = Factory.CreateIPrinters();
            int parsedAnimalId = -1;
            int parsedCustomerId = -1;

            Console.Clear();

            printer.IAnimalsPrinter(AnimalList);

            Console.WriteLine("Please enter ID of animal:");
            parsedAnimalId = parser.ParseId(Console.ReadLine());

            if (parsedAnimalId > 0)
            {
                Console.Clear();

                printer.ICustomersPrinter(Customers.CustomerList);
                Console.WriteLine("Please enter ID of customer:");
                parsedCustomerId = parser.ParseId(Console.ReadLine());
            }

            try
            {
                if (parsedAnimalId != -1 && parsedCustomerId != -1)
                {
                    selectedAnimal = finder.FindById(AnimalList, parsedAnimalId);
                    selectedCustomer = finder.FindById(Customers.CustomerList, parsedCustomerId);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally
            {
                if (selectedAnimal != null && selectedCustomer != null)
                {
                    selectedAnimal.Owner = selectedCustomer;
                    selectedCustomer.Animals.Add(selectedAnimal);
                    Console.WriteLine($"Successfully assigned {selectedAnimal.Name} to {selectedCustomer.Name}.");
                }
                else
                {
                    Console.WriteLine("Something went wrong. Please try again.");
                }
            }
        }

        public void AddExtraServices(IAnimal animal)
        {
            Console.WriteLine("Add extra services? Y / N");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                foreach (var service in ExtraServices.ExtraServicesList)
                {
                    Console.WriteLine($"{service.ServiceTitle}? Cost: {service.ServiceCost}");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        animal.ExtraServices.Add(service);
                    }
                }
            }
            return;
        }

        public void MarkAsInKennel()
        {
            IPrinters printers = Factory.CreateIPrinters();
            IParser parser = Factory.CreateIParser();
            IFinders finders = Factory.CreateIFinders();
            IAnimal selectedAnimal;
            var parsedAnimalId = -1;

            printers.IAnimalsPrinter(AnimalList);
            Console.WriteLine("Please enter ID of animal:");
            parsedAnimalId = parser.ParseId(Console.ReadLine());

            if (parsedAnimalId > 0)
            {
                selectedAnimal = finders.FindById(AnimalList, parsedAnimalId);
                selectedAnimal.IsInKennel = true;
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
        }

        public void MarkAsRetrieved()
        {
            IPrinters printers = Factory.CreateIPrinters();
            IParser parser = Factory.CreateIParser();
            IFinders finders = Factory.CreateIFinders();
            IAnimal selectedAnimal;
            var parsedAnimalId = -1;

            printers.IAnimalsPrinter(AnimalList);
            Console.WriteLine("Please enter ID of animal:");
            parsedAnimalId = parser.ParseId(Console.ReadLine());

            if (parsedAnimalId > 0)
            {
                selectedAnimal = finders.FindById(AnimalList, parsedAnimalId);
                selectedAnimal.IsInKennel = false;
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
        }

        public void Register()
        {
            Console.Clear();

            IAnimal animal = Factory.CreateIAnimal();

            Console.WriteLine("Name of animal:");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Species:");
            animal.Species = Console.ReadLine();

            Console.WriteLine("Breed:");
            animal.Breed = Console.ReadLine();

            animal.IsInKennel = true;

            AddExtraServices(animal);

            AnimalList.Add(animal);
        }
    }
}