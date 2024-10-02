
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Models;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace PortfolioBackend.Context
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<ProfessionalExperience> ProfessionalExperiences { get; set; }

        public required string postgresConnectionString { get; set; }

        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
        }

    }
}
