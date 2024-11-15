using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ThinDough : IDough 
    { 
        public string GetDoughType()
        {
            return "Тонкое тесто"; 
        }
    }
}