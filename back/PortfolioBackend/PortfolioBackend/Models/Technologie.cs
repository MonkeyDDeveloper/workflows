using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBackend.Models
{
    public class Technologie
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public required string Name { get; set; }

    }
}
