using CodePatterns_U1.Interfaces;
using System.Collections.Generic;

namespace CodePatterns_U1.Models
{
    public class Animal : IAnimal
    {
        protected static int IdCount = 1;

        public Animal()
        {
            Id = IdCount++;
            ExtraServices = new List<IExtraService>();
        }

        public string Breed { get; set; }
        public List<IExtraService> ExtraServices { get; set; }
        public int Id { get; set; }
        public bool IsInKennel { get; set; }
        public string Name { get; set; }
        public ICustomer Owner { get; set; }
        public string Species { get; set; }
    }
}