using Canteen.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Canteen.Core.EF
{
    public class CanteenDbContext: DbContext
    {
        public CanteenDbContext(DbContextOptions<CanteenDbContext> opt) : base(opt)
        {
            Database.EnsureCreated();
        }

        public DbSet<CookShop> CookShops { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<SizePrice> SizePrice { get; set; }
    }
}
