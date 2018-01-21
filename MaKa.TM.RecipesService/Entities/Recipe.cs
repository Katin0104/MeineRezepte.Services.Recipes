using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaKa.TM.RecipesService.Entities
{
    public class Recipe
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public decimal TotalTime { get; set; }

        public decimal WorkingTime { get; set; }

        public bool IsFavorite { get; set; }

        public decimal Portions { get; set; }

        public string ImageURL { get; set; }
    }
}
