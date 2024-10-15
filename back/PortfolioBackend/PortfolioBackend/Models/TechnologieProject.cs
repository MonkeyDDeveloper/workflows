using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PortfolioBackend.Models
{
    public class TechnologieProject
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Technologie")]
        [Column("technologie_id")]
        public int TechnologieId { get; set; }

        [ForeignKey("Project")]
        [Column("project_id")]
        public int ProjectId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public Project Project { get; set; } = null!;

        [NotMapped]
        public Technologie Technologie { get; set; } = null!;
    }
}
