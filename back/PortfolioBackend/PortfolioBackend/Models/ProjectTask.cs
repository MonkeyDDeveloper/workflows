using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBackend.Models
{
    public class ProjectTask
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("description")]
        public required string Description { get; set; }

        [NotMapped]
        public Project Project { get; set; } = null!;
    }
}
