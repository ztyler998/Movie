using ApplicationCore;
using ApplicationCore.Contracts;

namespace Infrasturcture.Repository;

public class PurchaseRepository: BaseRepository<Purchase>, IPurchaseRepository
{
    public PurchaseRepository(MovieDbContext context) : base(context)
    {
        
    }
}