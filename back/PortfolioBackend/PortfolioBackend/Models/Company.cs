using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBackend.Models
{
    public class Company
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("logo_path")]
        public required string LogoPath { get; set; }
    }
}
