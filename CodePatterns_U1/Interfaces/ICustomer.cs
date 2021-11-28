using System.Collections.Generic;

namespace CodePatterns_U1.Interfaces
{
    public interface ICustomer : IEntity
    {
        List<IAnimal> Animals { get; set; }
        string PhoneNumber { get; set; }
    }
}