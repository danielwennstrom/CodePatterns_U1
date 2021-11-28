using System.Collections.Generic;

namespace CodePatterns_U1.Interfaces
{
    public interface IAnimals : IRegistration
    {
        static List<IAnimal> AnimalList;

        void MarkAsInKennel();

        void MarkAsRetrieved();

        void AddExtraServices(IAnimal animal);

        void Assign();
    }
}