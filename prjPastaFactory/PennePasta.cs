using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPastaFactory
{
    internal class PennePasta : IPasta
    {
        public string getNoodle()
        {
            return "Tubular";
        }

        public string getSauce()
        {
            return "Vodka Sauce";
        }

        public string getMeat()
        {
            return "Pancetta";
        }
    }
}
