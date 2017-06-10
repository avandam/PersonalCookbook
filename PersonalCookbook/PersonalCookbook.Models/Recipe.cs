using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalCookbook.Models
{
    public class Recipe
    {
        public string Name { get; private set; }
        public int Id { get; private set; } = -1;
        public string Source { get; private set; }
        public int Rating { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }

        public Recipe(string name, string source, int rating, int id) : this(name, source, rating)
        {
            Id = id;
        }

        public Recipe(string name, string source, int rating)
        {
            Name = name;
            Source = source;
            Rating = rating;
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
