using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas10.Models
{
    public class Automobilis : TransportoPriemone
    {
        private int KeleiviuSkaicius { get; set; }

        public Automobilis(string marke, string modelis, int maksimalusGreitis, byte keleiviuSkaicius) : base(marke, modelis, maksimalusGreitis)
        {
            KeleiviuSkaicius = keleiviuSkaicius;
        }

        public override string ToString()
        {
            return "Automobilio " + base.ToString() + $" Keleiviu skaicius: {KeleiviuSkaicius}";
        }
    }
}
