using Microsoft.EntityFrameworkCore;

namespace chefDish.Models {
    public class chefAndDishContext : DbContext {
        public chefAndDishContext(DbContextOptions options) : base(options) {}
        public DbSet<Chef> chefs {get;set;}
        public DbSet<Dish> dishes {get;set;}
    }
}