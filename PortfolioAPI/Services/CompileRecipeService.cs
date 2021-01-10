using PortfolioExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using PortfolioExample.Data;
using PortfolioExample.Interfaces;

namespace PortfolioExample.Services
{
    public class CompileRecipeService : ICompileRecipeService
    {
        
        public CompileRecipeService()
        {

        }

        public Recipe compileRecipe(int recipeId)
        {
            using(var db = new DatabaseContext())
            {
                Recipe compiledRecipe = new Recipe();
                compiledRecipe.Steps = db.Steps.Where(o => o.RecipeId == recipeId).ToList();
                //foreach(var stp in compiledRecipe.Steps)
                //{
                //    stp.Action = db.Actions.FirstOrDefault(o => o.Id == stp.ActionId);
                //    stp.Measurements = db.Measurements.Where(o => db.MeasurementForSteps.Where(a => a.StepId == stp.Id).Select(a => a.Id).Contains(o.Id)).ToList();
                //    foreach(var measure in stp.Measurements)
                //    {
                //        measure.Ingredient = db.Ingredients.FirstOrDefault(o => o.Id == measure.IngredientId);
                //        measure.MeasurementType = db.MeasurementTypes.FirstOrDefault(o => o.Id == measure.MeasurementTypeId);
                //    }
                //}
                return compiledRecipe;

            }
        }

        public void createRecipe(Recipe recipe)
        {
            using (var db = new DatabaseContext())
            {
                db.Recipes.Add(recipe);

            }
        }

        public List<Recipe> getRecipes()
        {
            using (var db = new DatabaseContext())
            {
                List<Recipe> recipes = db.Recipes.Select(o => new Recipe() {
                    Id = o.Id,
                    Name = o.Name
                }).ToList();
                return recipes;
            }
        }
    }
}
