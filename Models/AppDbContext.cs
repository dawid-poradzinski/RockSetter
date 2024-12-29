using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext 
{
    public DbSet<RockEntity> Rocks {get;set;}
    private string DbPath {get;set;}
    public AppDbContext()
    {
        DbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "rocks.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data source={DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RockEntity>().HasData(
          new RockEntity()
          {
            Id = 1,
            Name = "amethyst",
            Density = 4,
            Favorible = false,
            Formula = "Si_02H20",
            Hardness = 4,
            Month = 4,
            ImageFileName = "amethyst.jpeg"
          },
            new RockEntity()
          {
            Id = 2,
            Name = "Emerald",
            Density = 4,
            Favorible = true,
            Formula = "Si_02H20",
            Hardness = 4,
            Month = 4,
            ImageFileName = "emerald.jpeg"
          }
        );
    }
}