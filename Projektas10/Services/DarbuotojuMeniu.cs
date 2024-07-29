using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas10.Models;

namespace Projektas10.Services
{
    public class DarbuotojuMeniu
    {
        private DarbuotojuValdymas _darbuotojuValdymas;
        public DarbuotojuMeniu(DarbuotojuValdymas darbuotojuValdymas)
        {
            _darbuotojuValdymas = darbuotojuValdymas;
        }

        /// <summary>
        /// Konsoles meniu rasymas ir skaitymas
        /// </summary>
        public void PaleistiMeniu()
        {
            while (true)
            {
                Console.WriteLine("1. Rodyti visus darbuotojus");
                Console.WriteLine("2. Pridėti programuotoja");
                Console.WriteLine("3. Pridėti testuotoja");
                Console.WriteLine("4. Pakeisti pagrindine programavimo kalba programuotojui");
                Console.WriteLine("5. Pridėti testuotojui automatizavimo patirti");
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                GetInput(out string pasirinkimas);
                try
                {
                    switch (pasirinkimas)
                    {
                        case "1":
                            Console.WriteLine();
                            foreach (Darbuotojas darbuotojas in _darbuotojuValdymas.GautiVisusDarbuotojus())
                            {
                                Console.WriteLine(darbuotojas);
                            }
                            break;
                        case "2":
                            Console.Write("Iveskite varda: ");
                            GetInput(out string vardas);
                            Console.Write("Iveskite pavarde: ");
                            GetInput(out string pavarde);
                            Console.Write("Iveskite atlyginima: ");
                            GetInput(out decimal atlyginimas);
                            Console.Write("Iveskite pagrindine programavimo kalba: ");
                            GetInput(out string programavimoKalba);
                            Console.WriteLine();
                            Console.WriteLine(_darbuotojuValdymas.PridetiDarbuotoja(new Programuotojas(vardas, pavarde, atlyginimas, programavimoKalba)));
                            break;
                        case "3":
                            Console.Write("Iveskite varda: ");
                            GetInput(out vardas);
                            Console.Write("Iveskite pavarde: ");
                            GetInput(out pavarde);
                            Console.Write("Iveskite atlyginima: ");
                            GetInput(out atlyginimas);
                            Console.Write("Iveskite ar testuotojas turi automatizavimo patirties (true/false): ");
                            GetInput(out bool bAutomatizavimas);
                            Console.WriteLine();
                            Console.WriteLine(_darbuotojuValdymas.PridetiDarbuotoja(new Testuotojas(vardas, pavarde, atlyginimas, bAutomatizavimas)));
                            break;
                        case "4":
                            Console.WriteLine();
                            if(RodytiProgramuotojuSarasa())
                            {
                                Console.WriteLine();
                                Console.Write("Pasirinkite programuotoja: ");
                                GetInput(out int index);
                                Console.Write("Iveskite nauja pagrindine programavimo kalba: ");
                                GetInput(out string kalba);
                                Console.WriteLine(_darbuotojuValdymas.PakeistiProgramuotojoKalba(index, kalba));
                            }
                            break;
                        case "5":
                            Console.WriteLine();
                            if(RodytiTestuotojuSarasa())
                            {
                                Console.WriteLine();
                                Console.Write("Pasirinkite testuotoja: ");
                                GetInput(out int index);
                                Console.WriteLine(_darbuotojuValdymas.PridetiTestuotojoPatirti(index));
                            }
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Neteisingas pasirinkimas.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Klaida: {ex.Message}");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pridedami testiniai duomenys, kad nereiktu visko suvedineti per meniu
        /// </summary>
        public void PridetiTestiniusDuomenis()
        {
            _darbuotojuValdymas.PridetiDarbuotoja(new Programuotojas("Linas", "Linaitis", 4000, "Java"));
            _darbuotojuValdymas.PridetiDarbuotoja(new Testuotojas("Petras", "Petraitis", 2500, true));
            _darbuotojuValdymas.PridetiDarbuotoja(new Programuotojas("Justas", "Justaitis", 3000, "C++"));
            _darbuotojuValdymas.PridetiDarbuotoja(new Testuotojas("Rita", "Ritaite", 2500, false));
            _darbuotojuValdymas.PridetiDarbuotoja(new Programuotojas("Jonas", "Jonaitis", 3500, "C#"));
        }

        /// <summary>
        /// Nuskaito vartotojo ivesti ir grazina string tipo rezultata
        /// </summary>
        /// <returns></returns>
        public void GetInput(out string input)
        {
            while (true)
            {
                input = Console.ReadLine() ?? string.Empty;
                if (input != "")
                    return;
                else
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
            }
        }

        /// <summary>
        /// Nuskaito vartotojo ivesti ir grazina decimal tipo rezultata
        /// </summary>
        /// <returns></returns>
        public void GetInput(out decimal input)
        {
            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out input) || input <= 0)
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
                else
                    return;
            }
        }

        /// <summary>
        /// Nuskaito vartotojo ivesti ir grazina bool tipo rezultata
        /// </summary>
        /// <returns></returns>
        public void GetInput(out bool input)
        {
            while (true)
            {
                if (!bool.TryParse(Console.ReadLine(), out input))
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
                else
                    return;
            }
        }

        /// <summary>
        /// Nuskaito vartotojo ivesti ir grazina int tipo rezultata
        /// </summary>
        /// <returns></returns>
        public void GetInput(out int input)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out input) || input < 1)
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
                else
                    return;
            }
        }

        public bool RodytiProgramuotojuSarasa()
        {
            int i = 1;

            foreach (Darbuotojas darbuotojas in _darbuotojuValdymas.GautiVisusDarbuotojus())
            {
                if (darbuotojas is Programuotojas)
                {
                    Console.WriteLine($"{i}. " + darbuotojas);
                    i++;
                }
            }
            if(i == 1)
                Console.WriteLine("Programuotoju nera!");
            return i > 0;
        }

        public bool RodytiTestuotojuSarasa()
        {
            int i = 1;

            foreach (Darbuotojas darbuotojas in _darbuotojuValdymas.GautiVisusDarbuotojus())
            {
                if (darbuotojas is Testuotojas && !((Testuotojas)darbuotojas).TuriPatirties())
                {
                    Console.WriteLine($"{i}. " + darbuotojas);
                    i++;
                }
            }
            if (i == 1)
                Console.WriteLine("Testuotoju nera!");
            return i > 0;
        }
    }
}
