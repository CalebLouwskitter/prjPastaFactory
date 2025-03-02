using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPastaFactory
{
    internal class SpaghettiPasta : IPasta
    {
        public string getNoodle()
        {
            return "Thin Round";
        }

        public string getSauce()
        {
            return "Marinara";
        }

        public string getMeat()
        {
            return "Meatballs";
        }
    }
}
