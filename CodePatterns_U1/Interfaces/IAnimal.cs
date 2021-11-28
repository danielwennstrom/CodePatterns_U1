using System.Collections.Generic;

namespace CodePatterns_U1.Interfaces
{
    public interface IAnimal : IEntity
    {
        string Breed { get; set; }
        ICustomer Owner { get; set; }
        string Species { get; set; }
        bool IsInKennel { get; set; }
        List<IExtraService> ExtraServices { get; set; }
    }
}