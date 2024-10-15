using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBackend.Models
{
    public class ProfessionalExperience
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public required string Title { get; set; }
        [Column("description")]
        public required string Description { get; set; }
        [Column("start_date")]
        public required DateOnly StartDate { get; set; }
        [Column("end_date")]
        public required DateOnly EndDate { get; set; }

        [Column("is_current")]
        public Boolean IsCurrent { get; set; } = false;

        [NotMapped]
        public ICollection<Responsabilitie> Responsabilities { get; set; } = null!;

        [NotMapped]
        public ICollection<TechnologieExperience> TechnologieExperiences { get; set; } = null!;

        [NotMapped]
        public CompanyExperience CompanyExperience { get; set; } = null!;

    }
}
