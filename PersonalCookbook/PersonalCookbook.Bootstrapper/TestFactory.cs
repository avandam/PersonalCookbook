using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Dal.Stub;
using PersonalCookbook.Logic;
using PersonalCookbook.Logic.Interfaces;

namespace PersonalCookbook.Bootstrapper
{
    internal static class TestFactory
    {
        internal static IRecipeRepository GetRecipeRepository()
        {
            return new RecipeRepository(new StubRecipeContext(), new StubIngredientContext());
        }
    }
}
