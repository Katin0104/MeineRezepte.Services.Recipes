using MaKa.TM.RecipesService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaKa.TM.RecipesService.Context
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes{ get; set; }
    }
}
