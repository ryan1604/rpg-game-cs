using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();

        static RecipeFactory()
        {
            Recipe granolaBar = new Recipe(1, "Granola Bar");
            granolaBar.AddIngredients(3001, 1);
            granolaBar.AddIngredients(3002, 1);
            granolaBar.AddIngredients(3003, 1);
            granolaBar.AddOutputItems(2001, 1);

            _recipes.Add(granolaBar);
        }

        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}
