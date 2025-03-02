using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPastaFactory
{
    internal class FettuccinePasta : IPasta
    {
        public string getNoodle()
        {
            return "Flat Ribbon";
        }

        public string getSauce()
        {
            return "Alfredo, Cream, Parmesan";
        }

        public string getMeat()
        {
            return "Chicken";
        }
    }
}
