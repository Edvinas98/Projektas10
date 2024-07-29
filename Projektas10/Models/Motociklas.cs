using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas10.Models
{
    public class Motociklas : TransportoPriemone
    {
        private bool bTuriSideCart { get; set; }

        public Motociklas(string marke, string modelis, int maksimalusGreitis, bool bSideCart) : base(marke, modelis, maksimalusGreitis)
        {
            bTuriSideCart = bSideCart;
        }

        public override string ToString()
        {
            string aprasymas = "Motociklo " + base.ToString();

            if (bTuriSideCart)
                aprasymas += "    Turi sonine priekaba";
            return aprasymas;
        }
    }
}
