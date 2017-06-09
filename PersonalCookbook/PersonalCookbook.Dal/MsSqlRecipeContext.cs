using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Dal.Interfaces;
using PersonalCookbook.Models;

namespace PersonalCookbook.Dal
{
    public class MsSqlRecipeContext : IRecipeContext
    {
        public List<Recipe> GetAllRecipes()
        {
            throw new NotImplementedException();
        }
    }
}
