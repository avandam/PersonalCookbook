using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Dal.Interfaces;
using PersonalCookbook.Models;

namespace PersonalCookbook.Dal.Stub
{
    public class StubIngredientContext : IIngredientContext
    {
        public List<Ingredient> GetIngredientsForRecipe(int recipeId)
        {
            return new List<Ingredient>() { new Ingredient("Tomaat"), new Ingredient("Soep")};
        }
    }
}
