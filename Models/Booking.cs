using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public string BookingReference { get; set; } = string.Empty;

        [ForeignKey("Venue")]
        public int VenueID { get; set; }

        [ForeignKey("Event")]
        public int EventID { get; set; }

        public Venue? Venue { get; set; }

        public Event? Event { get; set; }
    }
}