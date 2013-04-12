using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipePlanner.Domain
{
    public class Recipe
    {
        public IList<Ingedient> Ingredients { get; set; }
        public int Servings { get; set; }
        public int CaloriesPerServing { get; set; }
        
        public Recipe()
        {
            Ingredients = new List<Ingedient>();
        }

        public Recipe(int servings, int calories)
        {
            Servings = servings;
            CaloriesPerServing = calories;
            Ingredients = new List<Ingedient>();
        }
    }
}
