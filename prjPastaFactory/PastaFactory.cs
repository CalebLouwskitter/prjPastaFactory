using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPastaFactory
{
    public class PastaFactory
    {
        public IPasta returnInstance;

        public IPasta getPasta(string PastaType)
        {
            if (PastaType.ToLower().Equals("spaghetti"))
            {
                returnInstance = new SpaghettiPasta();
            }
            else if (PastaType.ToLower().Equals("fettuccine"))
            {
                returnInstance = new FettuccinePasta();
            }
            else if (PastaType.ToLower().Equals("penne"))
            {
                returnInstance = new PennePasta();
            }
            else
            {
                returnInstance = new PlainPasta();
            }
            return returnInstance;
        }
    }
}
