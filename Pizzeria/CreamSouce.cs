using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class CreamSouce : ISouce 
    { 
        public string GetSouceType()
        {
            return "Сливочный соус"; 
        }
    }
}