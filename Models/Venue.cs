using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]
        public int VenueID { get; set; }

        [Required]
        [StringLength(100)]
        public string VenueName { get; set; }

        [Required]
        [StringLength(150)]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        public string? ImageURL { get; set; }
    }
}