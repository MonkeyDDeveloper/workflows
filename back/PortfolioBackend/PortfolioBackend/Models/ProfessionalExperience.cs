namespace PortfolioBackend.Models
{
    public class ProfessionalExperience
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        public required string Description { get; set; }

        public required DateOnly StartDate { get; set; }

        public required DateOnly EndDateOnly { get; set; }

        public required List<string> Responsabilities { get; set; }

        public required List<string> Tecnologies { get; set; }

    }
}
