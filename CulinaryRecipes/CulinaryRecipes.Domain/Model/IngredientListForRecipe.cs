using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulinaryRecipes.Domain.Model
{
    public enum QuantityTypes
    {
        Weight, Piece
    }
    public class IngredientInRecipe
    {
        public int Id { get; set; }
        // public Recipe Recipe { get; set; }
        [Required]
        public Ingredient Ingredient { get; set; }
        [Required]
        public QuantityTypes QuantityType { get; set; }
        [Required]
        public int Value { get; set; }
        [DefaultValue(false)]
        public bool Required { get; set; } 
    }
}
