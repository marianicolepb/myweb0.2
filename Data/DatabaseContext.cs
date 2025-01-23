using Microsoft.EntityFrameworkCore;
using myweb0._2.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Pasatiempo> Pasatiempos { get; set; }
    public DbSet<AnimeOSerie> AnimesOSeries { get; set; }
    public DbSet<Genealogia> Genealogia { get; set; }
    public DbSet<Contacto> Contacto { get; set; }

    public DbSet<RedSocial> RedesSociales { get; set; }

    public DbSet<YouTuber> Youtubers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-CCHOB6Q;Database=WebAboutMe;User Id=sa;Password=12345678;TrustServerCertificate=True;");
    }
}
