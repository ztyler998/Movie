

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrasturcture // match your namespace exactly
{
    public class MovieDbContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
    {
        public MovieDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();

            // Replace with your actual connection string
            var connectionString =
                "Data Source=.;Initial Catalog=MovieDbApp;User Id=sa;Password=Tyler@8089900;Encrypt=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connectionString);

            return new MovieDbContext(optionsBuilder.Options);
        }
    }
}