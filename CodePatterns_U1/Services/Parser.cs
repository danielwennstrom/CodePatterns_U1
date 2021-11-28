using CodePatterns_U1.Interfaces;
using System;

namespace CodePatterns_U1.Services
{
    public class Parser : IParser
    {
        public int ParseId(string input)
        {
            int output = -1;
            try
            {
                output = Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error parsing ID: {0}. {1}", input, e.Message);
                Console.ReadKey();
            }
            return output;
        }
    }
}