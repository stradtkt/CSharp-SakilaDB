using Microsoft.EntityFrameworkCore;

namespace SakilaMVC.Models
{
    public class SakilaContext : DbContext
    {
       public SakilaContext(DbContextOptions<SakilaContext> options) : base(options) { }

       public DbSet<Film> film {get;set;}

       public DbSet<City> city {get;set;}
    }
}