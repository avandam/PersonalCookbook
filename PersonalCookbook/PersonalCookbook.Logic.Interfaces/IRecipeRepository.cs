using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Models;

namespace PersonalCookbook.Logic.Interfaces
{
    public interface IRecipeRepository
    {
        List<Recipe> GetAllRecipes();
        List<Recipe> GetRecipesWithIngredients();

    }
}
