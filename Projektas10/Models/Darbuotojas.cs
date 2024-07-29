using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas10.Models
{
    public class Darbuotojas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        protected decimal Atlyginimas { get; set; }

        public Darbuotojas(string vardas, string pavarde, decimal atlyginimas)
        {
            Vardas = vardas.PadRight(10);
            Pavarde = pavarde.PadRight(15);
            atlyginimas = Math.Floor(atlyginimas * 100M) * 0.01M;
            Atlyginimas = atlyginimas;
        }

        public bool PatikrintiVardaIrPavarde(string vardas, string pavarde)
        {
            if (Vardas == vardas && Pavarde == pavarde)
                return true;
            return false;
        }

        public override string ToString()
        {
            string atlyginimas = $"Atlyginimas: {Atlyginimas} Eur";
            atlyginimas = atlyginimas.PadRight(27);

            return $"{Vardas}{Pavarde}{atlyginimas}";
        }
    }
}
