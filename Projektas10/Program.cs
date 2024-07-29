using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas10.Contracts;
using Projektas10.Models;
using Projektas10.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projektas10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            //Task2();

            //TaskInterface();
        }

        static void Task1()
        {
            List<TransportoPriemone> transportoPriemones = new List<TransportoPriemone>();

            transportoPriemones.Add(new Automobilis("Audi", "A6", 240, 5));
            transportoPriemones.Add(new Motociklas("Moto", "Guzzi V7", 90, true));
            transportoPriemones.Add(new Automobilis("Honda", "Civic", 200, 3));
            transportoPriemones.Add(new Automobilis("Toyota", "Yaris", 190, 5));
            transportoPriemones.Add(new Motociklas("Kawasaki", "Eliminator 500", 160, false));

            Console.WriteLine("Transporto priemones: ");
            foreach (TransportoPriemone transportoPriemone in transportoPriemones)
            {
                Console.WriteLine(transportoPriemone);
            }
        }

        static void Task2()
        {
            DarbuotojuValdymas darbuotojuValdymas = new DarbuotojuValdymas();
            DarbuotojuMeniu darbuotojuMeniu = new DarbuotojuMeniu(darbuotojuValdymas);
            darbuotojuMeniu.PridetiTestiniusDuomenis();
            darbuotojuMeniu.PaleistiMeniu();
        }

        static void TaskInterface()
        {
            int start = 1;
            int end = 50;

            Console.WriteLine($"Check if numbers ({start}-{end}) can be divided by 3 and 5");           
            INumberProcessor numberProcessor = new NumberProcessor();
            numberProcessor.ProcessNumbers(start, end);
            Console.WriteLine();

            start = 1;
            end = 20;
            Console.WriteLine($"Check if numbers ({start}-{end}) are enen");
            IEvenOddChecker eveOddChecker = new EveOddChecker();
            eveOddChecker.CheckEvenOdd(start, end);
            Console.WriteLine();

            start = 1;
            end = 10;
            Console.WriteLine($"Print numbers ({start}-{end})");
            INumberPrinter numberPrinter = new NumberPrinter();
            numberPrinter.PrintNumbers(start, end);
        }
    }
}
