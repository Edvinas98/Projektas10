using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas10.Contracts;

namespace Projektas10.Services
{
    public class NumberProcessor : INumberProcessor
    {
        public void ProcessNumbers(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine($"Number {i} can be divided by 3 and 5");
                else if (i % 3 == 0)
                    Console.WriteLine($"Number {i} can be divided by 3");
                else if (i % 5 == 0)
                    Console.WriteLine($"Number {i} can be divided by 5");
                else
                    Console.WriteLine($"Number {i} can not be divided by 3 or 5");
            }
        }
    }
}
