using ApplicationCore;
using ApplicationCore.Contracts;

namespace Infrasturcture.Repository;

public class GenreRepository: BaseRepository<Genre>, IGenreRepository
{
    public GenreRepository(MovieDbContext context) : base(context)
    {
        
    }
}