using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Models;

namespace PersonalCookbook.Dal.Interfaces
{
    public interface IIngredientContext
    {
        List<Ingredient> GetIngredientsForRecipe(int recipeId);
    }
}
