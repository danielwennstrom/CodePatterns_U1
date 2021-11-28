namespace CodePatterns_U1.Interfaces
{
    public interface IIdentification
    {
        static int IdCount { get; set; }
        int Id { get; set; }
    }
}