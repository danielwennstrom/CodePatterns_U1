using System.Collections.Generic;

namespace CodePatterns_U1.Interfaces
{
    public interface IFinders
    {
        ICustomer FindById(List<ICustomer> customers, int id);

        IAnimal FindById(List<IAnimal> animals, int id);
    }
}