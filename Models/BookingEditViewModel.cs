namespace EventManager.Models
{
    public class BookingEditViewModel
    {
        public int BookingId { get; set; }
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int VenueId { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
