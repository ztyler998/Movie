using ApplicationCore;
using ApplicationCore.Contracts;

namespace Infrasturcture.Repository;

public class CastRepository: BaseRepository<Cast>, ICastRepository
{
    public CastRepository(MovieDbContext context): base(context)
    {
        
    }
}