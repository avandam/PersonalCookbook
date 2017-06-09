using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Models;

namespace PersonalCookbook.Dal.Interfaces
{
    public interface IRecipeContext
    {
        List<Recipe> GetAllRecipes();
    }
}
