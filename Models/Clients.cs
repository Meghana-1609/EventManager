namespace EventManager.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }

        // Navigation Property
        public ICollection<Booking> Bookings { get; set; }
    }
}
