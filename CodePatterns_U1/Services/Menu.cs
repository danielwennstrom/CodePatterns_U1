using CodePatterns_U1.Interfaces;
using System;

namespace CodePatterns_U1.Services
{
    public class Menu
    {
        public static bool MainMenu()
        {
            bool showMenu = true;
            IPrinters printer = Factory.CreateIPrinters();

            Console.WriteLine("(1) Register/Assign...");
            Console.WriteLine("(2) Show All...");
            Console.WriteLine("(3) Mark As...");
            Console.WriteLine("(4) Print Receipt");
            Console.WriteLine("(0) Exit");
            Console.WriteLine("Please select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    while (showMenu)
                    {
                        showMenu = SubMenuRegisterAssign();
                    }
                    return true;

                case "2":
                    while (showMenu)
                    {
                        showMenu = SubMenuShowAll();
                    }
                    return true;

                case "3":
                    while (showMenu)
                    {
                        showMenu = SubMenuMarkAs();
                    }
                    return true;

                case "4":
                    printer.ReceiptPrinter();
                    return true;

                case "0":
                    return false;

                default:
                    return true;
            }
        }

        public static bool SubMenuRegisterAssign()
        {
            ICustomers customers = Factory.CreateICustomers();
            IAnimals animals = Factory.CreateIAnimals();

            Console.WriteLine("(1) Register New Customer");
            Console.WriteLine("(2) Register New Animal");
            Console.WriteLine("(3) Assign Animal To Customer");
            Console.WriteLine("(0) Return To Main Menu");

            switch (Console.ReadLine())
            {
                case "1":
                    customers.Register();
                    return true;

                case "2":
                    animals.Register();
                    return true;

                case "3":
                    animals.Assign();
                    return true;

                case "0":
                    return false;

                default:
                    return true;
            }
        }

        public static bool SubMenuShowAll()
        {
            IPrinters printer = Factory.CreateIPrinters();

            Console.WriteLine("(1) Show All Customers");
            Console.WriteLine("(2) Show All Animals");
            Console.WriteLine("(3) Show All Animals Currently In Kennel");
            Console.WriteLine("(4) Show All Animals By Customer");
            Console.WriteLine("(0) Return To Main Menu");

            switch (Console.ReadLine())
            {
                case "1":
                    printer.ICustomersPrinter(Customers.CustomerList);
                    return true;

                case "2":
                    printer.IAnimalsPrinter(Animals.AnimalList);
                    return true;

                case "3":
                    printer.IAnimalsInKennelPrinter(Animals.AnimalList);
                    return true;

                case "4":
                    printer.IAnimalsByIdPrinter(Customers.CustomerList);
                    return true;

                case "0":
                    return false;

                default:
                    return true;
            }
        }

        public static bool SubMenuMarkAs()
        {
            IAnimals animals = Factory.CreateIAnimals();

            Console.WriteLine("(1) Mark As In Kennel");
            Console.WriteLine("(2) Mark As Retrieved");
            Console.WriteLine("(0) Return To Main Menu");

            switch (Console.ReadLine())
            {
                case "1":
                    animals.MarkAsInKennel();
                    return true;

                case "2":
                    animals.MarkAsRetrieved();
                    return true;

                case "0":
                    return false;

                default:
                    return true;
            }
        }
    }
}