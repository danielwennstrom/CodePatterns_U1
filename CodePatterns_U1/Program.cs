using CodePatterns_U1.Models;
using CodePatterns_U1.Services;

namespace CodePatterns_U1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customers.CustomerList = new()
            {
                new Customer { Name = "Harald Haraldsson", PhoneNumber = "12345678910" },
                new Customer { Name = "Erik Eriksson", PhoneNumber = "12345678910" },
                new Customer { Name = "Johan Johansson", PhoneNumber = "12345678910" },
                new Customer { Name = "Carl Carlsson", PhoneNumber = "12345678910" }
            };

            Animals.AnimalList = new()
            {
                new Animal { Name = "Ture", Species = "Cat", Breed = "Russian Blue", IsInKennel = true, Owner = Customers.CustomerList.Find(c => c.Id == 1), ExtraServices = ExtraServices.ExtraServicesList },
                new Animal { Name = "Greger", Species = "Dog", Breed = "Cocker Spaniel", IsInKennel = true, Owner = Customers.CustomerList.Find(c => c.Id == 1), ExtraServices = ExtraServices.ExtraServicesList.GetRange(0, 1) },
                new Animal { Name = "Arne", Species = "Dog", Breed = "Chihuahua", IsInKennel = true, Owner = Customers.CustomerList.Find(c => c.Id == 2), ExtraServices = ExtraServices.ExtraServicesList.GetRange(1, 1) },
                new Animal { Name = "Stig-Olof", Species = "Cat", Breed = "Korat", IsInKennel = true, Owner = Customers.CustomerList.Find(c => c.Id == 3) }
            };

            Customers.CustomerList[0].Animals.AddRange(Animals.AnimalList.GetRange(0, 2));
            Customers.CustomerList[1].Animals.AddRange(Animals.AnimalList.GetRange(2, 1));
            Customers.CustomerList[2].Animals.AddRange(Animals.AnimalList.GetRange(3, 1));

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.MainMenu();
            }
        }
    }
}