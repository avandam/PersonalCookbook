using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalCookbook.Models
{
    public class Ingredient
    {
        public string Name { get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Ingredient)
            {
                Ingredient otherIngredient = obj as Ingredient;
                if (this.Name == otherIngredient.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
