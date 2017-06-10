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

        //TODO Chantal: In the future we don't want to get all recipes, but get the summaries from the context based on filtering
        public List<RecipeSummary> GetAllRecipeSummaries()
        {
            List<Recipe> recipes = GetAllRecipes();
            List<RecipeSummary> summaries = new List<RecipeSummary>();
            foreach (Recipe recipe in recipes)
            {
                RecipeSummary summary = new RecipeSummary(recipe.Name, recipe.Source, recipe.Rating, recipe.Id);
                summaries.Add(summary);
            }
            return summaries;
        }

        public Recipe GetRecipeFromSummary(RecipeSummary summary)
        {
            List<Recipe> recipes = GetAllRecipes();
            return recipes.FirstOrDefault(rec => rec.Id == summary.Id);
        }
    }
}
