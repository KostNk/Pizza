using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ItalianPizzaFactory : PizzaFactory
    {
        public override IDough CreateDough() => new ThinDough();
        public override ISouce CreateSouce() => new TomatoSouce();
        public override List<IIngredient> CreateIngredients()
        {
            var listIngredients = new List<IIngredient> { new CheeseIngredient(), new MushroomIngredient() };
            return listIngredients;
        }
    }
}