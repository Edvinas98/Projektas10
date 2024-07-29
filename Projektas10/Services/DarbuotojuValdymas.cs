using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Projektas10.Models;

namespace Projektas10.Services
{
    public class DarbuotojuValdymas
    {
        public List<Darbuotojas> Darbuotojai { get; set; }


        public DarbuotojuValdymas()
        {
            Darbuotojai = new List<Darbuotojas>();
        }

        public string PridetiDarbuotoja(Darbuotojas naujasDarbuotojas)
        {
            bool bFound = false;

            foreach (Darbuotojas darbuotojas in Darbuotojai)
            {
                if (PatikrintiDarbuotoja(naujasDarbuotojas))
                    bFound = true;
            }
            if (bFound)
                return "Darbuotojas su tokiu vardu ir pavarde jau yra sarase!";

            Darbuotojai.Add(naujasDarbuotojas);
            return "Darbuotojas sekmingai pridetas";
        }

        public List<Darbuotojas> GautiVisusDarbuotojus()
        {
            return Darbuotojai;
        }

        public bool PatikrintiDarbuotoja(Darbuotojas naujasDarbuotojas)
        {
            foreach (Darbuotojas darbuotojas in Darbuotojai)
            {
                if (darbuotojas.PatikrintiVardaIrPavarde(naujasDarbuotojas.Vardas, naujasDarbuotojas.Pavarde))
                    return true;
            }
            return false;
        }

        public string PakeistiProgramuotojoKalba(int index, string kalba)
        {
            int i = 1;

            foreach (Darbuotojas darbuotojas in Darbuotojai)
            {
                if (darbuotojas is Programuotojas)
                {
                    if(i == index)
                    {
                        ((Programuotojas)darbuotojas).Persikvalifikuoti(kalba);
                        return "Programuotojas perkvalifikuotas";
                    }
                    i++;
                }
            }
            return "Programuotojas nerastas";
        }

        public string PridetiTestuotojoPatirti(int index)
        {
            int i = 1;

            foreach (Darbuotojas darbuotojas in Darbuotojai)
            {
                if (darbuotojas is Testuotojas && !((Testuotojas)darbuotojas).TuriPatirties())
                {
                    if (i == index)
                    {
                        ((Testuotojas)darbuotojas).IgautiPatirties();
                        return "Testuotojas igavo automatizavimo patirties";
                    }
                    i++;
                }
            }
            return "Testuotojas nerastas";
        }
    }
}
