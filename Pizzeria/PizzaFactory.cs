using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
// Фабрика пиццерий
    public abstract class PizzaFactory
    {
        public abstract IDough CreateDough();
        public abstract ISouce CreateSouce();
        public abstract List<IIngredient> CreateIngredients();
    }
}