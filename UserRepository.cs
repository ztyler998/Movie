using ApplicationCore;
using ApplicationCore.Contracts;

namespace Infrasturcture.Repository;

public class UserRepository: BaseRepository<User>, IUserRepository
{
    public UserRepository(MovieDbContext context) : base(context)
    {
    }
}