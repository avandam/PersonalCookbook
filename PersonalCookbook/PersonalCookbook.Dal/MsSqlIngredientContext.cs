using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Dal.Interfaces;
using PersonalCookbook.Models;

namespace PersonalCookbook.Dal
{
    public class MsSqlIngredientContext : IIngredientContext
    {
        public List<Ingredient> GetIngredientsForRecipe(int recipeId)
        {
            throw new NotImplementedException();
        }
    }
}
