using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas10.Models
{
    public class TransportoPriemone
    {
        protected string Marke { get; set; }
        protected string Modelis { get; set; }
        protected int MaksimalusGreitis { get; set; }

        public TransportoPriemone(string marke, string modelis, int maksimalusGreitis)
        {
            Marke = marke;
            Modelis = modelis;
            MaksimalusGreitis = maksimalusGreitis;
        }

        public override string ToString()
        {
            return $"marke: {Marke}     Modelis: {Modelis}      Max Greitis: {MaksimalusGreitis}";
        }
    }
}
