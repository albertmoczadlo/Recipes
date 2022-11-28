using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CulinaryRecipes.Domain.Model
{
    public class Fridge
    {
        public int Id { get; set; }
        public IdentityUser Owner { get; set; }
        public List<IngredientInFridge> IngredientInFridge { get; set; }
    }
}
