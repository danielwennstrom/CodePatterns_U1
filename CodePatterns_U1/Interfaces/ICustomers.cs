using System.Collections.Generic;

namespace CodePatterns_U1.Interfaces
{
    public interface ICustomers : IRegistration
    {
        static List<ICustomer> CustomerList;
    }
}