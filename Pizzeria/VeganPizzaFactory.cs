using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class VeganPizzaFactory : PizzaFactory
    {
        public override IDough CreateDough() => new GlutenLessDough();
        public override ISouce CreateSouce() => new CreamSouce();
        public override List<IIngredient> CreateIngredients()
        {
            var listIngredients=new List<IIngredient> { new MushroomIngredient() };
            return listIngredients;
        }
    }
}