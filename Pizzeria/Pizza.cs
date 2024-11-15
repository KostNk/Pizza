using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria
{
// Пицца
    public class Pizza : IPizza
    {
        private readonly IDough _dough;
        private readonly ISouce _souce;
        private readonly List<IIngredient> _ingredients;
        private readonly string _size;

        public Pizza(IDough dough, ISouce souce, List<IIngredient> ingredients, string size)
        {
            _dough = dough;
            _souce = souce;
            _ingredients = ingredients;
            _size = size;
        }

        public string GetDescription()
        {
            string ingredients = string.Join(", ", _ingredients.ConvertAll(i => i.GetIngredientName()));
            return $"{_size} пицца на {_dough.GetDoughType()} с {_souce.GetSouceType()} и ингредиентами: {ingredients}.";
        }
    }
}