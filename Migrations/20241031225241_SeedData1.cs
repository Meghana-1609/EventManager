using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2024, 10, 31, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2024, 11, 1, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "EmailId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 3, "alice.johnson@example.com", "Alice Johnson", "234-567-8901" },
                    { 4, "bob.brown@example.com", "Bob Brown", "345-678-9012" },
                    { 5, "charlie.wilson@example.com", "Charlie Wilson", "456-789-0123" },
                    { 6, "daisy.green@example.com", "Daisy Green", "567-890-1234" },
                    { 7, "ethan.white@example.com", "Ethan White", "678-901-2345" },
                    { 8, "fiona.black@example.com", "Fiona Black", "789-012-3456" },
                    { 9, "george.clark@example.com", "George Clark", "890-123-4567" },
                    { 10, "hannah.scott@example.com", "Hannah Scott", "901-234-5678" }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Budget", "Date" },
                values: new object[] { 15000, new DateTime(2024, 11, 30, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 15, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Budget", "Date", "EventType" },
                values: new object[,]
                {
                    { 3, 3000, new DateTime(2024, 12, 30, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5583), "Birthday Party" },
                    { 4, 10000, new DateTime(2025, 1, 14, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5585), "Product Launch" },
                    { 5, 8000, new DateTime(2025, 1, 29, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5587), "Conference" },
                    { 6, 2000, new DateTime(2025, 2, 13, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5589), "Workshop" },
                    { 7, 25000, new DateTime(2025, 2, 28, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5591), "Charity Gala" },
                    { 8, 12000, new DateTime(2025, 3, 15, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5593), "Trade Show" },
                    { 9, 7000, new DateTime(2025, 3, 30, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5595), "Graduation Ceremony" },
                    { 10, 9000, new DateTime(2025, 4, 14, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5596), "Fashion Show" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "Capacity", "Location", "VenueName" },
                values: new object[,]
                {
                    { 3, 200, "North End", "Open Garden" },
                    { 4, 150, "East Side", "Ballroom" },
                    { 5, 250, "South Wing", "Theatre" },
                    { 6, 120, "Downtown", "Banquet Hall" },
                    { 7, 80, "Uptown", "Rooftop Lounge" },
                    { 8, 350, "Seaside", "Beachside Pavilion" },
                    { 9, 200, "Suburbs", "Country Club" },
                    { 10, 500, "Central Plaza", "Convention Center" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "BookingDate", "ClientId", "EventId", "VenueId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 11, 2, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5628), 3, 3, 3 },
                    { 4, new DateTime(2024, 11, 3, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5630), 4, 4, 4 },
                    { 5, new DateTime(2024, 11, 4, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5632), 5, 5, 5 },
                    { 6, new DateTime(2024, 11, 5, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5634), 6, 6, 6 },
                    { 7, new DateTime(2024, 11, 6, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5635), 7, 7, 7 },
                    { 8, new DateTime(2024, 11, 7, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5637), 8, 8, 8 },
                    { 9, new DateTime(2024, 11, 8, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5639), 9, 9, 9 },
                    { 10, new DateTime(2024, 11, 9, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5641), 10, 10, 10 },
                    { 11, new DateTime(2024, 11, 10, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5643), 1, 2, 3 },
                    { 12, new DateTime(2024, 11, 11, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5645), 2, 3, 4 },
                    { 13, new DateTime(2024, 11, 12, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5647), 3, 4, 5 },
                    { 14, new DateTime(2024, 11, 13, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5649), 4, 5, 6 },
                    { 15, new DateTime(2024, 11, 14, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5650), 5, 6, 7 },
                    { 16, new DateTime(2024, 11, 15, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5652), 6, 7, 8 },
                    { 17, new DateTime(2024, 11, 16, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5654), 7, 8, 9 },
                    { 18, new DateTime(2024, 11, 17, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5656), 8, 9, 10 },
                    { 19, new DateTime(2024, 11, 18, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5658), 9, 10, 1 },
                    { 20, new DateTime(2024, 11, 19, 17, 52, 41, 180, DateTimeKind.Local).AddTicks(5660), 10, 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2024, 10, 31, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2024, 11, 1, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Budget", "Date" },
                values: new object[] { 10000, new DateTime(2024, 11, 30, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 15, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7649));
        }
    }
}
