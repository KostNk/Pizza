using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class TomatoSouce : ISouce 
    { 
        public string GetSouceType()
        {
            return "Томатный соус"; 
        }
    }
}