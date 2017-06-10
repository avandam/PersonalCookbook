using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalCookbook.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Bootstrapper;
using PersonalCookbook.Dal.Stub;
using PersonalCookbook.Models;
using PersonalCookbook.Logic.Interfaces;

namespace PersonalCookbook.Logic.Tests
{
    [TestClass()]
    public class RecipeRepositoryTests
    {
        [TestMethod()]
        public void GetAllRecipesTest()
        {
            // Setup
            
            IRecipeRepository repo = TestFactory.GetRecipeRepository();
            List<Recipe> expectedRecipes = new List<Recipe>();
            expectedRecipes.Add(new Recipe("TomatenSoep", "Chantal", 4, 1));

            // Do
            List<Recipe> actualRecipes = repo.GetAllRecipes();

            // Assert
            Assert.AreEqual(1, actualRecipes.Count);
            Assert.IsTrue(actualRecipes[0].Equals(expectedRecipes[0]));
        }

        [TestMethod()]
        public void GetRecipesWithIngredientsTest()
        {
            IRecipeRepository repo = new RecipeRepository(new StubRecipeContext(), new StubIngredientContext());
            List<Recipe> expectedRecipes = new List<Recipe>();
            Recipe recipe = new Recipe("TomatenSoep", "Chantal", 4, 1);
            List<Ingredient> ingredients = new List<Ingredient>() { new Ingredient("Tomaat"), new Ingredient("Soep") };
            recipe.AddIngredients(ingredients);
            expectedRecipes.Add(recipe);

            // Do
            List<Recipe> actualRecipes = repo.GetRecipesWithIngredients();

            // Assert
            Assert.AreEqual(1, actualRecipes.Count);
            Assert.IsTrue(actualRecipes[0].Equals(expectedRecipes[0]));
            for (int i = 0; i < actualRecipes[0].Ingredients.Count; i++)
            {
                Assert.IsTrue(actualRecipes[0].Ingredients[i].Equals(expectedRecipes[0].Ingredients[i]));
            }
        }
    }
}