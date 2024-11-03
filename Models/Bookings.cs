namespace EventManager.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        // Foreign Key Properties
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int VenueId { get; set; }

        // Navigation Properties
        public Client Client { get; set; }
        public Event Event { get; set; }
        public Venue Venue { get; set; }

        public DateTime BookingDate { get; set; }
    }
}
