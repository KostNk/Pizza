using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class MushroomIngredient : IIngredient 
    {
        public string GetIngredientName()
        {
            return "Грибы"; 
        }
    }
}