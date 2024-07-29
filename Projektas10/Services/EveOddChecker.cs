using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas10.Contracts;

namespace Projektas10.Services
{
    public class EveOddChecker : IEvenOddChecker
    {
        public void CheckEvenOdd(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Number {i} is even");
                else
                    Console.WriteLine($"Number {i} is odd");
            }
        }
    }
}
