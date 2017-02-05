using Microsoft.EntityFrameworkCore;

namespace FoodService.Models
{
    public class FoodServiceDbContext : DbContext
    {

        public FoodServiceDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
