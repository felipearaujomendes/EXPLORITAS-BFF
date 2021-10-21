using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Exploritas.Infrastructure.Data.Contexts
{
    public class PortfolioContext : BaseDbContext
    {
        public PortfolioContext()
        {

        }

        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(PortfolioContext).Assembly);
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            base.OnModelCreating(builder);
        }
    }
}
