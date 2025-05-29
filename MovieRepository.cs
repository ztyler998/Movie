using ApplicationCore;
using ApplicationCore.Contracts;

namespace Infrasturcture.Repository;

public class MovieRepository: BaseRepository<Movie>, IMovieRepository
{
    public MovieRepository(MovieDbContext context) : base(context)
    {
        
    }
}