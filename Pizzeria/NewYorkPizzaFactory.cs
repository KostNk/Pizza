using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class NewYorkPizzaFactory : PizzaFactory
    {
        public override IDough CreateDough() => new ThickDough();
        public override ISouce CreateSouce() => new BBQSouce();
        public override List<IIngredient> CreateIngredients()
        {
            var listIngredients = new List<IIngredient> { new CheeseIngredient(), new Pepperoni() };
            return listIngredients;
        }
}
}