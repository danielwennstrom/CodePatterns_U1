using CodePatterns_U1.Interfaces;
using System.Collections.Generic;

namespace CodePatterns_U1.Models
{
    public class Customer : ICustomer
    {
        private static int IdCount = 1;

        public Customer()
        {
            Id = IdCount++;
            Animals = new List<IAnimal>();
        }

        public List<IAnimal> Animals { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}