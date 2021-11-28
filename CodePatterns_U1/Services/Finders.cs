using CodePatterns_U1.Interfaces;
using System.Collections.Generic;

namespace CodePatterns_U1.Services
{
    public class Finders : IFinders
    {
        public ICustomer FindById(List<ICustomer> customers, int id)
        {
            return customers.Find(x => x.Id == id);
        }

        public IAnimal FindById(List<IAnimal> animals, int id)
        {
            return animals.Find(x => x.Id == id);
        }
    }
}