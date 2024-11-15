using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class PizzaOrder
    {
        private readonly PizzaFactory _factory;

        public PizzaOrder(PizzaFactory factory)
        {
            _factory = factory;
        }

        public IPizza CreateOrder(string size)
        {
            var dough = _factory.CreateDough();
            var souce = _factory.CreateSouce();
            var ingredients = _factory.CreateIngredients();

            return new Pizza(dough, souce, ingredients, size);
        }
    }
}