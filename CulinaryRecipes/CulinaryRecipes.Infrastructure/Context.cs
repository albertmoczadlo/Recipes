﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CulinaryRecipes.Infrastructure
{
    public class appContext: IdentityDbContext
    {
        public appContext(DbContextOptions options):base(options)
        {

        }
    }
}
