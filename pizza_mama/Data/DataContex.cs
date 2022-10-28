using Microsoft.EntityFrameworkCore;
using pizza_mama.Models;

namespace pizza_mama.Data {
    public class DataContex : DbContext {
        public DataContex(DbContextOptions<DataContex> options) : base(options) { }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
