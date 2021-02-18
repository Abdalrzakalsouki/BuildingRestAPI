using System.ComponentModel.DataAnnotations;

namespace BuildingRestAPI.Modles
{
    public class Building
    {
        public int BuildingId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(1, 1000)]
        public int Number { get; set; }
        [Required]
        [MaxLength(200)]
        public string Location { get; set; }
        public string ImageUrl { get; set; }

    }
}
