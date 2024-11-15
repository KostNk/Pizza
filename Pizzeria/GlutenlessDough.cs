using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class GlutenLessDough : IDough 
    { 
        public string GetDoughType()
        { 
            return "Безглютеновое тесто"; 
        }
    }
}