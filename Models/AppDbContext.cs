using Microsoft.EntityFrameworkCore;

namespace EventManager.Models
{
    public class AppDbContext : DbContext
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet properties for each model
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Venue> Venues { get; set; }

        // Configure relationships and model-specific configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship between Booking and Client
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Client)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.ClientId);

            // Configure the one-to-many relationship between Booking and Event
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Event)
                .WithMany(e => e.Bookings)
                .HasForeignKey(b => b.EventId);

            // Configure the one-to-many relationship between Booking and Venue
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Venue)
                .WithMany(v => v.Bookings)
                .HasForeignKey(b => b.VenueId);

            // Seed Clients
            modelBuilder.Entity<Client>().HasData(
                new Client { ClientId = 1, Name = "John Doe", EmailId = "john.doe@example.com", PhoneNumber = "123-456-7890" },
                new Client { ClientId = 2, Name = "Jane Smith", EmailId = "jane.smith@example.com", PhoneNumber = "098-765-4321" },
                new Client { ClientId = 3, Name = "Alice Johnson", EmailId = "alice.johnson@example.com", PhoneNumber = "234-567-8901" },
                new Client { ClientId = 4, Name = "Bob Brown", EmailId = "bob.brown@example.com", PhoneNumber = "345-678-9012" },
                new Client { ClientId = 5, Name = "Charlie Wilson", EmailId = "charlie.wilson@example.com", PhoneNumber = "456-789-0123" },
                new Client { ClientId = 6, Name = "Daisy Green", EmailId = "daisy.green@example.com", PhoneNumber = "567-890-1234" },
                new Client { ClientId = 7, Name = "Ethan White", EmailId = "ethan.white@example.com", PhoneNumber = "678-901-2345" },
                new Client { ClientId = 8, Name = "Fiona Black", EmailId = "fiona.black@example.com", PhoneNumber = "789-012-3456" },
                new Client { ClientId = 9, Name = "George Clark", EmailId = "george.clark@example.com", PhoneNumber = "890-123-4567" },
                new Client { ClientId = 10, Name = "Hannah Scott", EmailId = "hannah.scott@example.com", PhoneNumber = "901-234-5678" }
            );

            // Seed Venues
            modelBuilder.Entity<Venue>().HasData(
                new Venue { VenueId = 1, VenueName = "Grand Hall", Location = "City Center", Capacity = 300 },
                new Venue { VenueId = 2, VenueName = "Conference Room A", Location = "West Wing", Capacity = 100 },
                new Venue { VenueId = 3, VenueName = "Open Garden", Location = "North End", Capacity = 200 },
                new Venue { VenueId = 4, VenueName = "Ballroom", Location = "East Side", Capacity = 150 },
                new Venue { VenueId = 5, VenueName = "Theatre", Location = "South Wing", Capacity = 250 },
                new Venue { VenueId = 6, VenueName = "Banquet Hall", Location = "Downtown", Capacity = 120 },
                new Venue { VenueId = 7, VenueName = "Rooftop Lounge", Location = "Uptown", Capacity = 80 },
                new Venue { VenueId = 8, VenueName = "Beachside Pavilion", Location = "Seaside", Capacity = 350 },
                new Venue { VenueId = 9, VenueName = "Country Club", Location = "Suburbs", Capacity = 200 },
                new Venue { VenueId = 10, VenueName = "Convention Center", Location = "Central Plaza", Capacity = 500 }
            );

            // Seed Events
            modelBuilder.Entity<Event>().HasData(
                new Event { EventId = 1, EventType = "Wedding", Date = DateTime.Now.AddDays(30), Budget = 15000 },
                new Event { EventId = 2, EventType = "Corporate Meeting", Date = DateTime.Now.AddDays(45), Budget = 5000 },
                new Event { EventId = 3, EventType = "Birthday Party", Date = DateTime.Now.AddDays(60), Budget = 3000 },
                new Event { EventId = 4, EventType = "Product Launch", Date = DateTime.Now.AddDays(75), Budget = 10000 },
                new Event { EventId = 5, EventType = "Conference", Date = DateTime.Now.AddDays(90), Budget = 8000 },
                new Event { EventId = 6, EventType = "Workshop", Date = DateTime.Now.AddDays(105), Budget = 2000 },
                new Event { EventId = 7, EventType = "Charity Gala", Date = DateTime.Now.AddDays(120), Budget = 25000 },
                new Event { EventId = 8, EventType = "Trade Show", Date = DateTime.Now.AddDays(135), Budget = 12000 },
                new Event { EventId = 9, EventType = "Graduation Ceremony", Date = DateTime.Now.AddDays(150), Budget = 7000 },
                new Event { EventId = 10, EventType = "Fashion Show", Date = DateTime.Now.AddDays(165), Budget = 9000 }
            );

            // Seed Bookings
            modelBuilder.Entity<Booking>().HasData(
                new Booking { BookingId = 1, ClientId = 1, EventId = 1, VenueId = 1, BookingDate = DateTime.Now },
                new Booking { BookingId = 2, ClientId = 2, EventId = 2, VenueId = 2, BookingDate = DateTime.Now.AddDays(1) },
                new Booking { BookingId = 3, ClientId = 3, EventId = 3, VenueId = 3, BookingDate = DateTime.Now.AddDays(2) },
                new Booking { BookingId = 4, ClientId = 4, EventId = 4, VenueId = 4, BookingDate = DateTime.Now.AddDays(3) },
                new Booking { BookingId = 5, ClientId = 5, EventId = 5, VenueId = 5, BookingDate = DateTime.Now.AddDays(4) },
                new Booking { BookingId = 6, ClientId = 6, EventId = 6, VenueId = 6, BookingDate = DateTime.Now.AddDays(5) },
                new Booking { BookingId = 7, ClientId = 7, EventId = 7, VenueId = 7, BookingDate = DateTime.Now.AddDays(6) },
                new Booking { BookingId = 8, ClientId = 8, EventId = 8, VenueId = 8, BookingDate = DateTime.Now.AddDays(7) },
                new Booking { BookingId = 9, ClientId = 9, EventId = 9, VenueId = 9, BookingDate = DateTime.Now.AddDays(8) },
                new Booking { BookingId = 10, ClientId = 10, EventId = 10, VenueId = 10, BookingDate = DateTime.Now.AddDays(9) },
                new Booking { BookingId = 11, ClientId = 1, EventId = 2, VenueId = 3, BookingDate = DateTime.Now.AddDays(10) },
                new Booking { BookingId = 12, ClientId = 2, EventId = 3, VenueId = 4, BookingDate = DateTime.Now.AddDays(11) },
                new Booking { BookingId = 13, ClientId = 3, EventId = 4, VenueId = 5, BookingDate = DateTime.Now.AddDays(12) },
                new Booking { BookingId = 14, ClientId = 4, EventId = 5, VenueId = 6, BookingDate = DateTime.Now.AddDays(13) },
                new Booking { BookingId = 15, ClientId = 5, EventId = 6, VenueId = 7, BookingDate = DateTime.Now.AddDays(14) },
                new Booking { BookingId = 16, ClientId = 6, EventId = 7, VenueId = 8, BookingDate = DateTime.Now.AddDays(15) },
                new Booking { BookingId = 17, ClientId = 7, EventId = 8, VenueId = 9, BookingDate = DateTime.Now.AddDays(16) },
                new Booking { BookingId = 18, ClientId = 8, EventId = 9, VenueId = 10, BookingDate = DateTime.Now.AddDays(17) },
                new Booking { BookingId = 19, ClientId = 9, EventId = 10, VenueId = 1, BookingDate = DateTime.Now.AddDays(18) },
                new Booking { BookingId = 20, ClientId = 10, EventId = 1, VenueId = 2, BookingDate = DateTime.Now.AddDays(19) }
            );
        }
    }
}
