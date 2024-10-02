
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Models;

namespace PortfolioBackend.Context
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> builderOptions) : base(builderOptions)
        {
            
        }

        public DbSet<ProfessionalExperience> ProfessionalExperiences { get; set; }
    }
}
