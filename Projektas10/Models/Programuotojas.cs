using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas10.Models
{
    public class Programuotojas : Darbuotojas
    {
        protected string ProgramavimoKalba { get; set; }

        public Programuotojas(string vardas, string pavarde, decimal atlyginimas, string programavimokalba) : base(vardas, pavarde, atlyginimas)
        {
            ProgramavimoKalba = programavimokalba;
        }

        public void Persikvalifikuoti(string naujaKalba)
        {
            ProgramavimoKalba = naujaKalba;
        }

        public override string ToString()
        {
            return base.ToString()+$"{ProgramavimoKalba} programuotojas";
        }
    }
}
