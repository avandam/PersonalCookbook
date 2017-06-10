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
            expectedRecipes.Add(new Recipe("TomatenSoep", "Chantal", 4, "blaat", 1));
            expectedRecipes.Add(new Recipe("ChampignonSoep", "Rudolph", 3,"schaap", 2));

            // Do
            List<Recipe> actualRecipes = repo.GetAllRecipes();

            // Assert
            Assert.AreEqual(2, actualRecipes.Count);
            Assert.IsTrue(actualRecipes[0].Equals(expectedRecipes[0]));
            Assert.IsTrue(actualRecipes[1].Equals(expectedRecipes[1]));
        }

        [TestMethod()]
        public void GetRecipesWithIngredientsTest()
        {
            IRecipeRepository repo = new RecipeRepository(new StubRecipeContext(), new StubIngredientContext());
            List<Recipe> expectedRecipes = new List<Recipe>();
            Recipe recipe = new Recipe("TomatenSoep", "Chantal", 4, "blaat", 1);
            List<Ingredient> ingredients = new List<Ingredient>() { new Ingredient("Tomaat"), new Ingredient("Soep") };
            recipe.AddIngredients(ingredients);
            expectedRecipes.Add(recipe);
            recipe = new Recipe("ChanpignonSoep", "Rudolph", 3, "schaap", 2);
            ingredients = new List<Ingredient>() {new Ingredient("Champignon"), new Ingredient("Soep")};
            recipe.AddIngredients(ingredients);
            expectedRecipes.Add(recipe);

            // Do
            List<Recipe> actualRecipes = repo.GetRecipesWithIngredients();

            // Assert
            Assert.AreEqual(2, actualRecipes.Count);
            Assert.IsTrue(actualRecipes[0].Equals(expectedRecipes[0]));
            Assert.IsTrue(actualRecipes[1].Equals(expectedRecipes[1]));
            for (int i = 0; i < actualRecipes[0].Ingredients.Count; i++)
            {
                Assert.IsTrue(actualRecipes[0].Ingredients[i].Equals(expectedRecipes[0].Ingredients[i]));
            }
            for (int i = 0; i < actualRecipes[1].Ingredients.Count; i++)
            {
                Assert.IsTrue(actualRecipes[1].Ingredients[i].Equals(expectedRecipes[1].Ingredients[i]));
            }
        }

        [TestMethod()]
        public void GetAllRecipeSummariesTest()
        {
            IRecipeRepository repo = new RecipeRepository(new StubRecipeContext());
            List<RecipeSummary> expectedSummaries= new List<RecipeSummary>();
            RecipeSummary summary = new RecipeSummary("TomatenSoep", "Chantal", 4, 1);
            expectedSummaries.Add(summary);
            summary = new RecipeSummary("ChampignonSoep", "Rudolph", 3, 2);
            expectedSummaries.Add(summary);

            List<RecipeSummary> actualSummaries = repo.GetAllRecipeSummaries();

            Assert.AreEqual(2, actualSummaries.Count);
            Assert.IsTrue(actualSummaries[0].Equals(expectedSummaries[0]));
            Assert.IsTrue(actualSummaries[1].Equals(expectedSummaries[1]));
        }
    }
}