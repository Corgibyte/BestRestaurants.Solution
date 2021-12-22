using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public DBestRestaurants<Cuisine> Cuisines { get; set; }
    public DBSet<Restaurant> Restaurants { get; set; }

    public BestRestaurantsContext(DbContextOptions options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}