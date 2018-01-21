using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaKa.TM.RecipesService.Context;
using MaKa.TM.RecipesService.Entities;
using MaKa.TM.RecipesService.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaKa.TM.RecipesService.Controllers
{

    [Produces("application/json")]
    [Route("api/RecipeCards")]
    public class RecipeCardsController : Controller
    {

        private RecipeContext _context;

        public RecipeCardsController(RecipeContext context)
        {
            _context = context;
        }

        
        [HttpGet("listCards")]
        [ProducesResponseType(typeof(List<RecipeCardViewModel>), 200)]
        public List<RecipeCardViewModel> ListCards()
        {
            return _context.Recipes.AsNoTracking()
                .Select(recipe => new RecipeCardViewModel()
                {
                    Name = recipe.Name,
                    Favorite = recipe.IsFavorite,
                    Portions = recipe.Portions,
                    WorkingTime = recipe.WorkingTime,
                    TotalTime = recipe.TotalTime,
                    ImageURL = recipe.ImageURL
                }).ToList();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeCardViewModel recipeVM)
        {
            if (recipeVM == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var recipe = _context.Recipes.Add(
                new Recipe()
                {
                    ImageURL = recipeVM.ImageURL,
                    IsFavorite = recipeVM.Favorite,
                    Name = recipeVM.Name,
                    Portions = recipeVM.Portions,
                    TotalTime = recipeVM.TotalTime,
                    WorkingTime = recipeVM.WorkingTime
                }
            );
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecipe", new { id = recipe.Entity.ID }, recipe.Entity);
        }
    }
}