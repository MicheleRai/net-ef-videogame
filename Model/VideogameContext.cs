using Microsoft.EntityFrameworkCore;

public class VideogameContext : DbContext
{
    public DbSet<Videogame> Videogames { get; set; }
    public DbSet<SoftwareHouse> SoftwareHouse { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=videogameTestdb;Integrated Security=True; Encrypt = false;");
    }

}
