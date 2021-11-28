using CodePatterns_U1.Interfaces;

namespace CodePatterns_U1.Models
{
    public class ExtraService : IExtraService
    {
        public string ServiceTitle { get; set; }
        public double ServiceCost { get; set; }
    }
}