using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalCookbook.Models
{
    public class RecipeSummary
    {
        public string Name { get; private set; }
        public string Source { get; private set; }
        public int Rating { get; private set; }
        public int Id { get; private set; } = -1;

        public RecipeSummary(string name, string source, int rating, int id)
        {
            Name = name;
            Source = source;
            Rating = rating;
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (obj is RecipeSummary)
            {
                RecipeSummary otherRecipe = obj as RecipeSummary;
                if ( this.Id != -1 && this.Id == otherRecipe.Id )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
