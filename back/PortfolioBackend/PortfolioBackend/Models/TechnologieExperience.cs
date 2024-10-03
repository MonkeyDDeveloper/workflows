using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PortfolioBackend.Models
{
    public class TechnologieExperience
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Technologie")]
        [Column("technologie_id")]
        public int TechnologieId { get; set; }

        [ForeignKey("ProfessionalExperience")]
        [Column("experience_id")]
        public int ExperienceId { get; set; }


        [NotMapped]
        [JsonIgnore]
        public ProfessionalExperience ProfessionalExperience { get; set; } = null!;

        [NotMapped]
        public Technologie Technologie { get; set; } = null!;
    }
}
