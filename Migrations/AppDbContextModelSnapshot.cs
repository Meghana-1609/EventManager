﻿// <auto-generated />
using System;
using EventManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventManager.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventManager.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("ClientId");

                    b.HasIndex("EventId");

                    b.HasIndex("VenueId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            BookingDate = new DateTime(2024, 10, 31, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5623),
                            ClientId = 1,
                            EventId = 1,
                            VenueId = 1
                        },
                        new
                        {
                            BookingId = 2,
                            BookingDate = new DateTime(2024, 11, 1, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5626),
                            ClientId = 2,
                            EventId = 2,
                            VenueId = 2
                        },
                        new
                        {
                            BookingId = 3,
                            BookingDate = new DateTime(2024, 11, 2, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5628),
                            ClientId = 3,
                            EventId = 3,
                            VenueId = 3
                        },
                        new
                        {
                            BookingId = 4,
                            BookingDate = new DateTime(2024, 11, 3, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5630),
                            ClientId = 4,
                            EventId = 4,
                            VenueId = 4
                        },
                        new
                        {
                            BookingId = 5,
                            BookingDate = new DateTime(2024, 11, 4, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5632),
                            ClientId = 5,
                            EventId = 5,
                            VenueId = 5
                        },
                        new
                        {
                            BookingId = 6,
                            BookingDate = new DateTime(2024, 11, 5, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5634),
                            ClientId = 6,
                            EventId = 6,
                            VenueId = 6
                        },
                        new
                        {
                            BookingId = 7,
                            BookingDate = new DateTime(2024, 11, 6, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5635),
                            ClientId = 7,
                            EventId = 7,
                            VenueId = 7
                        },
                        new
                        {
                            BookingId = 8,
                            BookingDate = new DateTime(2024, 11, 7, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5637),
                            ClientId = 8,
                            EventId = 8,
                            VenueId = 8
                        },
                        new
                        {
                            BookingId = 9,
                            BookingDate = new DateTime(2024, 11, 8, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5639),
                            ClientId = 9,
                            EventId = 9,
                            VenueId = 9
                        },
                        new
                        {
                            BookingId = 10,
                            BookingDate = new DateTime(2024, 11, 9, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5641),
                            ClientId = 10,
                            EventId = 10,
                            VenueId = 10
                        },
                        new
                        {
                            BookingId = 11,
                            BookingDate = new DateTime(2024, 11, 10, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5643),
                            ClientId = 1,
                            EventId = 2,
                            VenueId = 3
                        },
                        new
                        {
                            BookingId = 12,
                            BookingDate = new DateTime(2024, 11, 11, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5645),
                            ClientId = 2,
                            EventId = 3,
                            VenueId = 4
                        },
                        new
                        {
                            BookingId = 13,
                            BookingDate = new DateTime(2024, 11, 12, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5647),
                            ClientId = 3,
                            EventId = 4,
                            VenueId = 5
                        },
                        new
                        {
                            BookingId = 14,
                            BookingDate = new DateTime(2024, 11, 13, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5649),
                            ClientId = 4,
                            EventId = 5,
                            VenueId = 6
                        },
                        new
                        {
                            BookingId = 15,
                            BookingDate = new DateTime(2024, 11, 14, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5650),
                            ClientId = 5,
                            EventId = 6,
                            VenueId = 7
                        },
                        new
                        {
                            BookingId = 16,
                            BookingDate = new DateTime(2024, 11, 15, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5652),
                            ClientId = 6,
                            EventId = 7,
                            VenueId = 8
                        },
                        new
                        {
                            BookingId = 17,
                            BookingDate = new DateTime(2024, 11, 16, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5654),
                            ClientId = 7,
                            EventId = 8,
                            VenueId = 9
                        },
                        new
                        {
                            BookingId = 18,
                            BookingDate = new DateTime(2024, 11, 17, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5656),
                            ClientId = 8,
                            EventId = 9,
                            VenueId = 10
                        },
                        new
                        {
                            BookingId = 19,
                            BookingDate = new DateTime(2024, 11, 18, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5658),
                            ClientId = 9,
                            EventId = 10,
                            VenueId = 1
                        },
                        new
                        {
                            BookingId = 20,
                            BookingDate = new DateTime(2024, 11, 19, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5660),
                            ClientId = 10,
                            EventId = 1,
                            VenueId = 2
                        });
                });

            modelBuilder.Entity("EventManager.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            EmailId = "john.doe@example.com",
                            Name = "John Doe",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            ClientId = 2,
                            EmailId = "jane.smith@example.com",
                            Name = "Jane Smith",
                            PhoneNumber = "098-765-4321"
                        },
                        new
                        {
                            ClientId = 3,
                            EmailId = "alice.johnson@example.com",
                            Name = "Alice Johnson",
                            PhoneNumber = "234-567-8901"
                        },
                        new
                        {
                            ClientId = 4,
                            EmailId = "bob.brown@example.com",
                            Name = "Bob Brown",
                            PhoneNumber = "345-678-9012"
                        },
                        new
                        {
                            ClientId = 5,
                            EmailId = "charlie.wilson@example.com",
                            Name = "Charlie Wilson",
                            PhoneNumber = "456-789-0123"
                        },
                        new
                        {
                            ClientId = 6,
                            EmailId = "daisy.green@example.com",
                            Name = "Daisy Green",
                            PhoneNumber = "567-890-1234"
                        },
                        new
                        {
                            ClientId = 7,
                            EmailId = "ethan.white@example.com",
                            Name = "Ethan White",
                            PhoneNumber = "678-901-2345"
                        },
                        new
                        {
                            ClientId = 8,
                            EmailId = "fiona.black@example.com",
                            Name = "Fiona Black",
                            PhoneNumber = "789-012-3456"
                        },
                        new
                        {
                            ClientId = 9,
                            EmailId = "george.clark@example.com",
                            Name = "George Clark",
                            PhoneNumber = "890-123-4567"
                        },
                        new
                        {
                            ClientId = 10,
                            EmailId = "hannah.scott@example.com",
                            Name = "Hannah Scott",
                            PhoneNumber = "901-234-5678"
                        });
                });

            modelBuilder.Entity("EventManager.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<int>("Budget")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            Budget = 15000,
                            Date = new DateTime(2024, 11, 30, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5526),
                            EventType = "Wedding"
                        },
                        new
                        {
                            EventId = 2,
                            Budget = 5000,
                            Date = new DateTime(2024, 12, 15, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5581),
                            EventType = "Corporate Meeting"
                        },
                        new
                        {
                            EventId = 3,
                            Budget = 3000,
                            Date = new DateTime(2024, 12, 30, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5583),
                            EventType = "Birthday Party"
                        },
                        new
                        {
                            EventId = 4,
                            Budget = 10000,
                            Date = new DateTime(2025, 1, 14, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5585),
                            EventType = "Product Launch"
                        },
                        new
                        {
                            EventId = 5,
                            Budget = 8000,
                            Date = new DateTime(2025, 1, 29, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5587),
                            EventType = "Conference"
                        },
                        new
                        {
                            EventId = 6,
                            Budget = 2000,
                            Date = new DateTime(2025, 2, 13, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5589),
                            EventType = "Workshop"
                        },
                        new
                        {
                            EventId = 7,
                            Budget = 25000,
                            Date = new DateTime(2025, 2, 28, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5591),
                            EventType = "Charity Gala"
                        },
                        new
                        {
                            EventId = 8,
                            Budget = 12000,
                            Date = new DateTime(2025, 3, 15, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5593),
                            EventType = "Trade Show"
                        },
                        new
                        {
                            EventId = 9,
                            Budget = 7000,
                            Date = new DateTime(2025, 3, 30, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5595),
                            EventType = "Graduation Ceremony"
                        },
                        new
                        {
                            EventId = 10,
                            Budget = 9000,
                            Date = new DateTime(2025, 4, 14, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5596),
                            EventType = "Fashion Show"
                        });
                });

            modelBuilder.Entity("EventManager.Models.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueId");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            VenueId = 1,
                            Capacity = 300,
                            Location = "City Center",
                            VenueName = "Grand Hall"
                        },
                        new
                        {
                            VenueId = 2,
                            Capacity = 100,
                            Location = "West Wing",
                            VenueName = "Conference Room A"
                        },
                        new
                        {
                            VenueId = 3,
                            Capacity = 200,
                            Location = "North End",
                            VenueName = "Open Garden"
                        },
                        new
                        {
                            VenueId = 4,
                            Capacity = 150,
                            Location = "East Side",
                            VenueName = "Ballroom"
                        },
                        new
                        {
                            VenueId = 5,
                            Capacity = 250,
                            Location = "South Wing",
                            VenueName = "Theatre"
                        },
                        new
                        {
                            VenueId = 6,
                            Capacity = 120,
                            Location = "Downtown",
                            VenueName = "Banquet Hall"
                        },
                        new
                        {
                            VenueId = 7,
                            Capacity = 80,
                            Location = "Uptown",
                            VenueName = "Rooftop Lounge"
                        },
                        new
                        {
                            VenueId = 8,
                            Capacity = 350,
                            Location = "Seaside",
                            VenueName = "Beachside Pavilion"
                        },
                        new
                        {
                            VenueId = 9,
                            Capacity = 200,
                            Location = "Suburbs",
                            VenueName = "Country Club"
                        },
                        new
                        {
                            VenueId = 10,
                            Capacity = 500,
                            Location = "Central Plaza",
                            VenueName = "Convention Center"
                        });
                });

            modelBuilder.Entity("EventManager.Models.Booking", b =>
                {
                    b.HasOne("EventManager.Models.Client", "Client")
                        .WithMany("Bookings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventManager.Models.Event", "Event")
                        .WithMany("Bookings")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventManager.Models.Venue", "Venue")
                        .WithMany("Bookings")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Event");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("EventManager.Models.Client", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("EventManager.Models.Event", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("EventManager.Models.Venue", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}