using System.ComponentModel.DataAnnotations;

namespace Kias_Kar_Kompany.Models
{
    public class Owner
    {
        [Key]
        public int ownerId { get; set; }

        [MaxLength(50)]
        public required string ownerName { get; set; }

        public string? ownerEmail { get; set; }

        public required int ownerNumber {  get; set; }
        public List<Vehicle>? Vehicles { get; set; }
    }
}
