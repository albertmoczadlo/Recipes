using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulinaryRecipes.Domain.Model
{
    public  class IngredientTags
    {
        public int Id { get; set; }
        [Required]
        public string Tag { get; set; }
    }
}
