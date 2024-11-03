namespace EventManager.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventType { get; set; }
        public DateTime Date { get; set; }
        public int Budget { get; set; }

        // Navigation Property
        public ICollection<Booking> Bookings { get; set; }
    }
}
