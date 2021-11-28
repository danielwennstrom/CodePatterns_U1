using CodePatterns_U1.Interfaces;
using CodePatterns_U1.Models;
using System.Collections.Generic;

namespace CodePatterns_U1.Services
{
    internal class ExtraServices : IExtraServices
    {
        public static List<IExtraService> ExtraServicesList => new()
        {
            new ExtraService { ServiceTitle = "Washing", ServiceCost = 25.50 },
            new ExtraService { ServiceTitle = "Claw Trimming", ServiceCost = 30.50 }
        };
    }
}