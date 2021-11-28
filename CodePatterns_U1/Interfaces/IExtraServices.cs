using System.Collections.Generic;

namespace CodePatterns_U1.Interfaces
{
    public interface IExtraServices
    {
        static List<IExtraService> ExtraServices { get; set; }
    }
}