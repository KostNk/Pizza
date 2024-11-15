using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ThickDough : IDough 
    { 
        public string GetDoughType()
        {
            return "Толстое тесто"; 
        }
    }
}