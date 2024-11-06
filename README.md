## Meghana Event Management System - Project

## WSUID -- V443Y829
## GithubLink -- https://github.com/Meghana-1609/EventManager/
## YoutubeLink -- http://youtube.con

## Overview

The Meghana Event Management System is a web application built with ASP.NET Core MVC and Entity Framework Core. It enables users to manage event-related data efficiently, providing functionality to create, read, update, and delete records for events, clients, and venues. The system is designed to streamline event organization by offering a user-friendly, responsive interface with key management tools.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Project Structure](#project-structure)
- [Database Structure](#database-structure)
- [Technologies Used](#technologies-used)

##List of Github Commits
<img width="1317" alt="Screenshot 2024-11-06 at 12 18 50 AM" src="https://github.com/user-attachments/assets/d00f2e83-1fcc-47dc-9119-3de0364d5e0a">


## Features

- **Event Management**: Manage events, including details like event type, date, and budget.
- **Client Management**: Store and view client details, contact information, and linked events.
- **Venue Management**: Track venue details such as name, location, and capacity.
- **Responsive Interface**: An intuitive, mobile-friendly design with a customizable navigation bar.
- **Detailed Navigation**: Quickly switch between Events, Clients, and Venues through an organized, styled navbar.
- **Error Handling**: Graceful error handling and notifications for smoother user experience.

## Project Structure

- **Controllers**:
  - `EventsController`: Handles CRUD operations for event records.
  - `ClientsController`: Manages client data operations.
  - `VenuesController`: Manages venue data operations.

- **Models**:
  - `Event`: Represents an event record.
  - `Client`: Represents a client with contact details.
  - `Venue`: Represents venue information with location and capacity.
  - `Booking`: Represents a booking with relationships to Events, Clients, and Venues.

- **Views**:
  - `Views/Events`: Contains views to list, create, edit, and delete events.
  - `Views/Clients`: Contains views to list, create, edit, and delete clients.
  - `Views/Venues`: Contains views to list, create, edit, and delete venues.
  - `Views/Shared`: Contains shared layout (`_Layout.cshtml`) and partial views.

- **Static Files**:
  - `wwwroot/css`: Contains custom stylesheets.
  - `wwwroot/lib`: Contains Bootstrap and other third-party libraries.

## Database Structure

The system’s database is managed using Entity Framework Core, with the following structure:

### Tables and Relationships

1. **Bookings**
   - `BookingId` (Primary Key)
   - `ClientId` (Foreign Key referencing `Clients.ClientId`)
   - `EventId` (Foreign Key referencing `Events.EventId`)
   - `VenueId` (Foreign Key referencing `Venues.VenueId`)
   - `BookingDate` (DateTime)

2. **Events**
   - `EventId` (Primary Key)
   - `EventType` (String)
   - `Date` (DateTime)
   - `Budget` (Decimal)

3. **Clients**
   - `ClientId` (Primary Key)
   - `Name` (String)
   - `EmailId` (String)
   - `PhoneNumber` (String)

4. **Venues**
   - `VenueId` (Primary Key)
   - `VenueName` (String)
   - `Location` (String)
   - `Capacity` (Integer)

### Entity Relationships

- **One-to-Many**:
  - Each `Client` can have multiple `Bookings`.
  - Each `Event` can have multiple `Bookings`.
  - Each `Venue` can have multiple `Bookings`.

This relational structure allows the application to handle complex event scenarios, tracking which clients are associated with specific events and venues through the `Bookings` table. The `Booking` table serves as a bridge, connecting `Clients`, `Events`, and `Venues` for streamlined management.

## Setup Instructions

### Prerequisites

1. [.NET SDK](https://dotnet.microsoft.com/download)
2. [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) for database management

### Getting Started

1. **Clone the Repository**

   ```bash
   git clone https://github.com/your-username/event-management-system.git
   cd event-management-system
