using CodePatterns_U1.Interfaces;
using CodePatterns_U1.Models;

namespace CodePatterns_U1.Services
{
    public static class Factory
    {
        public static IAnimal CreateIAnimal()
        {
            return new Animal();
        }

        public static IAnimals CreateIAnimals()
        {
            return new Animals();
        }

        public static ICustomer CreateICustomer()
        {
            return new Customer();
        }

        public static ICustomers CreateICustomers()
        {
            return new Customers();
        }

        public static IFinders CreateIFinders()
        {
            return new Finders();
        }

        public static IParser CreateIParser()
        {
            return new Parser();
        }

        public static IPrinters CreateIPrinters()
        {
            return new Printers();
        }

        public static ITally CreateITally()
        {
            return new Tally();
        }
    }
}