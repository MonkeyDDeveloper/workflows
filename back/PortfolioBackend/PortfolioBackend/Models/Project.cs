using PortfolioBackend.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBackend.Models
{
    public class Project
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("description")]
        public required string Description { get; set; }


        [NotMapped]
        public ICollection<ProjectTask> ProjectTasks { get; set; } = null!;

        [NotMapped]
        public ICollection<TechnologieProject> ProjectTechnologies { get; set; } = null!;
    }
}
