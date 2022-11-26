
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CulinaryRecipes.Domain.Model;
using Microsoft.EntityFrameworkCore.Internal;
using System.Reflection.Emit;

namespace CulinaryRecipes.Infrastructure
{
    public class ApplicationContext: IdentityDbContext
    {
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<IngredientInRecipe> IngredientInRecipe { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<IngredientType> IngredientType { get; set; }
        public DbSet<IngredientTags> IngredientTags { get; set; }

        public ApplicationContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
