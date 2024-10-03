using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PortfolioBackend.Models
{
    public class Responsabilitie
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("experience_id")]

        [ForeignKey("ProfessionalExperience")]
        public required int ExperienceId { get; set; }
        [Column("description")]

        public required string Description { get; set; }

        [JsonIgnore]
        public ProfessionalExperience ProfessionalExperience { get; set; } = null!;

    }
}
