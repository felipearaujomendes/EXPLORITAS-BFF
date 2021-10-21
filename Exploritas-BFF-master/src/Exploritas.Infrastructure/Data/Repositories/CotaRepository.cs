using Exploritas.Domain.Entities;
using Exploritas.Domain.Repositories;
using Exploritas.Infrastructure.Data.Contexts;

namespace Exploritas.Infrastructure.Data.Repositories
{
    public class CotaRepository: Repository<Cota>, ICotaRepository
    {
        public CotaRepository(PortfolioContext context) : base(context)
        {
        }
    }
}
