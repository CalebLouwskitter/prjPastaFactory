using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPastaFactory
{
    internal class PlainPasta : IPasta
    {
        public string getNoodle()
        {
            return "Linguine";
        }

        public string getSauce()
        {
            return "Olive Oil and Garlic";
        }

        public string getProtein()
        {
            return "None";
        }
    }
}
