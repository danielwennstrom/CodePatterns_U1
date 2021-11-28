namespace CodePatterns_U1.Interfaces
{
    public interface ITally
    {
        int TallyBaseCost(IAnimal animal);

        double TallyExtraServicesCost(IAnimal animal);
    }
}