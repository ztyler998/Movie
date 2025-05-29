using ApplicationCore;
using ApplicationCore.Contracts;

namespace Infrasturcture.Repository;

public class ReportRepository: BaseRepository<Report>, IReportRepository
{
    public ReportRepository(MovieDbContext context) : base(context)
    {
        
    }
}