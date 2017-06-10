using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalCookbook.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public int Id { get; private set; } = -1;
        public string Source { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(string name, string source, int rating, string comment, int id) : this(name, source, rating, comment)
        {
            Id = id;
        }

        public Recipe(string name, string source, int rating, string comment)
        {
            Name = name;
            Source = source;
            Rating = rating;
            Comment = comment;
            Ingredients = new List<Ingredient>();
        }

        public override bool Equals(object obj)
        {
            if (obj is Recipe)
            {
                Recipe otherRecipe = obj as Recipe;
                if (this.Id != -1 && this.Id == otherRecipe.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void AddIngredients(List<Ingredient> ingredients)
        {
            Ingredients.AddRange(ingredients);
        }
    }
}
