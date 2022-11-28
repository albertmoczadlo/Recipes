using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulinaryRecipes.Domain.Model
{
    public class IngredientInFridge
    {
            public int Id { get; set; }
            // public Recipe Recipe { get; set; }
            [Required]
            public Ingredient Ingredient { get; set; }
            [Required]
            public QuantityTypes QuantityType { get; set; }
            [Required]
            public int Value { get; set; }
    }
}
