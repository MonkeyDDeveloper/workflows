using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PortfolioBackend.Models
{
    public class CompanyExperience
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Company")]
        [Column("company_id")]
        public int CompanyId { get; set; }

        [ForeignKey("ProfessionalExperience")]
        [Column("experience_id")]
        public int ExperienceId { get; set; }


        [NotMapped]
        [JsonIgnore]
        public ProfessionalExperience ProfessionalExperience { get; set; } = null!;

        [NotMapped]
        public Company Company { get; set; } = null!;
    }
}
