using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Food> Food { get; set; }
    }
}
