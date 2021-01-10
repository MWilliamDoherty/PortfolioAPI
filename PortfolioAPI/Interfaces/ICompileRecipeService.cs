using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioExample.Models;

namespace PortfolioExample.Interfaces
{
    public interface ICompileRecipeService
    {
        public Recipe compileRecipe(int recipeId);
        public void createRecipe(Recipe recipe);
        public List<Recipe> getRecipes();
    }
}
