using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaKa.TM.RecipesService.ViewModels
{
    public class RecipeCardViewModel
    {
        public string Name { get; set; }
        public int Portions { get; set; }
        public decimal TotalTime { get; set; }
        public decimal WorkingTime { get; set; }
        public bool Favorite { get; set; }
        public string ImageURL { get; set; }
    }
}
