using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class BBQSouce : ISouce 
    { 
        public string GetSouceType()
        {
            return "Барбекю соус"; 
        }
    }
}