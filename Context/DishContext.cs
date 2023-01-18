using Microsoft.EntityFrameworkCore;

namespace JaegarRestoAPI;

public class JaegarRestoContext : DbContext {

  public JaegarRestoContext(DbContextOptions<JaegarRestoContext> options) : base(options)
  {
  }

  public DbSet<Dish> Dishes { get; set; }
  
  public DbSet<Category> Categories { get; set; }
}