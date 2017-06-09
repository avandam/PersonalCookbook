using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Dal.Interfaces;
using PersonalCookbook.Logic.Interfaces;
using PersonalCookbook.Models;

namespace PersonalCookbook.Logic
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IRecipeContext recipeContext;
        private readonly IIngredientContext ingredientContext;

        public RecipeRepository(IRecipeContext recipeContext)
        {
            this.recipeContext = recipeContext;
        }

        public RecipeRepository(IRecipeContext recipeContext, IIngredientContext ingredientContext)
        {
            this.recipeContext = recipeContext;
            this.ingredientContext = ingredientContext;
        }

        public List<Recipe> GetAllRecipes()
        {
            return recipeContext.GetAllRecipes();
        }

        public List<Recipe> GetRecipesWithIngredients()
        {
            List<Recipe> recipes = GetAllRecipes();
            foreach (Recipe recipe in recipes)
            {
                List<Ingredient> ingredients = ingredientContext.GetIngredientsForRecipe(recipe.Id);
                recipe.AddIngredients(ingredients);
            }
            return recipes;
        }
    }
}
