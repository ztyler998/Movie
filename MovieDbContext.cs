using ApplicationCore;
using Microsoft.EntityFrameworkCore;

namespace Infrasturcture;

public class MovieDbContext: DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options): base(options)
    {
        
    }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Movie> Movies { get; set; }
}
