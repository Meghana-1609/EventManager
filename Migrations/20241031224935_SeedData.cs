using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "EmailId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John Doe", "123-456-7890" },
                    { 2, "jane.smith@example.com", "Jane Smith", "098-765-4321" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Budget", "Date", "EventType" },
                values: new object[,]
                {
                    { 1, 10000, new DateTime(2024, 11, 30, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7592), "Wedding" },
                    { 2, 5000, new DateTime(2024, 12, 15, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7649), "Corporate Meeting" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "Capacity", "Location", "VenueName" },
                values: new object[,]
                {
                    { 1, 300, "City Center", "Grand Hall" },
                    { 2, 100, "West Wing", "Conference Room A" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "BookingDate", "ClientId", "EventId", "VenueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 31, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7669), 1, 1, 1 },
                    { 2, new DateTime(2024, 11, 1, 17, 49, 35, 340, DateTimeKind.Local).AddTicks(7672), 2, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "VenueId",
                keyValue: 2);
        }
    }
}
