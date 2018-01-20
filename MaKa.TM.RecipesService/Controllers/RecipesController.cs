using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaKa.TM.RecipesService.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaKa.TM.RecipesService.Controllers
{
    [Produces("application/json")]
    [Route("api/Recipes")]
    public class RecipesController : Controller
    {
        [HttpGet("listCards")]
        [ProducesResponseType(typeof(List<RecipeCardViewModel>), 200)]
        public List<RecipeCardViewModel> ListCards()
        {
            var recipeCardList = new List<RecipeCardViewModel>()
            {
                new RecipeCardViewModel()
                {
                    Name = "Hamburger",
                    Portions = 5,
                    TotalTime = 30,
                    WorkingTime = 10,
                    Favorite = true,
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-djYZAELSqGKP52_OUoR7lvyovnhZkcn_ZnmW7gs1g6bL77PPgQ"
                },
                 new RecipeCardViewModel()
                {
                    Name = "Pizza",
                    Portions = 5,
                    TotalTime = 30,
                    WorkingTime = 10,
                    Favorite = true,
                    ImageURL = "https://d3a76jc0ho84i8.cloudfront.net/static/desktop/products/pizza-salami.jpg"
                }
            };

            return recipeCardList;
        }
    }
}