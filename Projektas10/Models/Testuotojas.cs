using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas10.Models
{
    public class Testuotojas : Darbuotojas
    {
        protected bool bTuriAutomatizavimoPatirties { get; set; }

        public Testuotojas(string vardas, string pavarde, decimal atlyginimas, bool bAutomatizavimoPatirtis) : base(vardas, pavarde, atlyginimas)
        {
            bTuriAutomatizavimoPatirties = bAutomatizavimoPatirtis;
        }

        public void IgautiPatirties()
        {
            bTuriAutomatizavimoPatirties = true;
        }

        public bool TuriPatirties()
        {
            return bTuriAutomatizavimoPatirties;
        }

        public override string ToString()
        {
            string automatizavimas = bTuriAutomatizavimoPatirties ? "turi" : "neturi";

            return base.ToString() + $"testuotojas, automatizavimo patirties " + automatizavimas;
        }
    }
}
