using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Dal;
using PersonalCookbook.Logic;
using PersonalCookbook.Logic.Interfaces;

namespace PersonalCookbook.Bootstrapper
{
    public static class Factory
    {
        public static IRecipeRepository GetRecipeRepository()
        {
            return new RecipeRepository(new MsSqlRecipeContext(), new MsSqlIngredientContext());
        }
    }
}
