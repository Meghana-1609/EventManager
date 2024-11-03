namespace EventManager.Models
{
    public class BookingsViewModel
    {
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int VenueId { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
