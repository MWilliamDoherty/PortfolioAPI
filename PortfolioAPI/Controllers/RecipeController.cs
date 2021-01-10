using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioExample.Services;
using PortfolioExample.Interfaces;
using PortfolioExample.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace PortfolioExample.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    [ApiController]
    [AllowAnonymous]
    public class RecipeController : ControllerBase
    {
        private ICompileRecipeService _service;

        public RecipeController()
        {
            _service = new CompileRecipeService();

            
        }

        [HttpGet]
        public List<Recipe> getRecipeNames()
        {
            List<Recipe> recipes = _service.getRecipes();
            return recipes;
        }

        [HttpGet("{id}")]
        public Recipe GetRecipe(int id)
        {
            Recipe recipe = _service.compileRecipe(id);
            return recipe;
        }
    }
}
