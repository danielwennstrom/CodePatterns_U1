using CodePatterns_U1.Interfaces;

namespace CodePatterns_U1.Services
{
    public class Tally : ITally
    {
        public int TallyBaseCost(IAnimal animal)
        {
            var baseCost = 200;
            return baseCost;
        }

        public double TallyExtraServicesCost(IAnimal animal)
        {
            double servicesCost = 0;
            foreach (var service in animal.ExtraServices)
            {
                servicesCost = servicesCost + service.ServiceCost;
            }
            return servicesCost;
        }
    }
}