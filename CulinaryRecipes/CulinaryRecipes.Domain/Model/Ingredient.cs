using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CulinaryRecipes.Domain.Model
{

    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public IngredientType IngradientType { get; set; }

    }
}
