using MaKa.TM.RecipesService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaKa.TM.RecipesService.Context
{
    public static class RecipeDbInitializer
    {
        public static void Initialize(RecipeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any recipes.
            if (context.Recipes.Any())
            {
                return;   // DB has been seeded
            }

            context.Recipes.Add(
                new Recipe()
                {
                    Name = "Hamburger",
                    Portions = 5,
                    TotalTime = 30,
                    WorkingTime = 10,
                    IsFavorite = true,
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-djYZAELSqGKP52_OUoR7lvyovnhZkcn_ZnmW7gs1g6bL77PPgQ"
                }
            );

            context.Recipes.Add(
                new Recipe()
                {
                    Name = "Pizza",
                    Portions = 5,
                    TotalTime = 30,
                    WorkingTime = 10,
                    IsFavorite = true,
                    ImageURL = "https://d3a76jc0ho84i8.cloudfront.net/static/desktop/products/pizza-salami.jpg"
                }
            );

            context.SaveChanges();
        }
    }
}
