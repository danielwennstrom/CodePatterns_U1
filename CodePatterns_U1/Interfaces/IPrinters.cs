using System.Collections.Generic;

namespace CodePatterns_U1.Interfaces
{
    public interface IPrinters
    {
        string IAnimalPrinter(IAnimal obj);

        void IAnimalsByIdPrinter(List<ICustomer> list);

        void IAnimalsInKennelPrinter(List<IAnimal> list);

        void IAnimalsPrinter(List<IAnimal> list);

        string ICustomerPrinter(ICustomer obj);

        void ICustomersPrinter(List<ICustomer> list);

        void IExtraServicesPrinter(List<IExtraService> list);

        void ReceiptPrinter();
    }
}