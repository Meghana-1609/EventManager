using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventManager.Models;

namespace EventManager.Controllers
{
    public class BookingsController : Controller
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Bookings.Include(b => b.Client).Include(b => b.Event).Include(b => b.Venue);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Client)
                .Include(b => b.Event)
                .Include(b => b.Venue)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Clients, "ClientId", "ClientId");
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            ViewData["VenueId"] = new SelectList(_context.Venues, "VenueId", "VenueId");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientId,EventId,VenueId,BookingDate")] BookingsViewModel bookingViewModel)
        {
            if (ModelState.IsValid)
            {
                // Map BookingsViewModel to Booking entity
                var booking = new Booking
                {
                    ClientId = bookingViewModel.ClientId,
                    EventId = bookingViewModel.EventId,
                    VenueId = bookingViewModel.VenueId,
                    BookingDate = bookingViewModel.BookingDate
                };

                // Save the Booking entity to the database
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Repopulate dropdown lists if ModelState is invalid
            ViewData["ClientId"] = new SelectList(_context.Clients, "ClientId", "ClientId", bookingViewModel.ClientId);
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", bookingViewModel.EventId);
            ViewData["VenueId"] = new SelectList(_context.Venues, "VenueId", "VenueId", bookingViewModel.VenueId);

            return View(bookingViewModel);
        }


        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            // Map Booking entity to BookingEditViewModel
            var bookingViewModel = new BookingEditViewModel
            {
                BookingId = booking.BookingId,
                ClientId = booking.ClientId,
                EventId = booking.EventId,
                VenueId = booking.VenueId,
                BookingDate = booking.BookingDate
            };

            // Populate dropdown lists
            ViewData["ClientId"] = new SelectList(_context.Clients, "ClientId", "ClientId", bookingViewModel.ClientId);
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", bookingViewModel.EventId);
            ViewData["VenueId"] = new SelectList(_context.Venues, "VenueId", "VenueId", bookingViewModel.VenueId);

            return View(bookingViewModel);
        }


        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,ClientId,EventId,VenueId,BookingDate")] BookingEditViewModel bookingViewModel)
        {
            if (id != bookingViewModel.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Map BookingsViewModel to Booking entity
                    var booking = await _context.Bookings.FindAsync(id);
                    if (booking == null)
                    {
                        return NotFound();
                    }

                    booking.ClientId = bookingViewModel.ClientId;
                    booking.EventId = bookingViewModel.EventId;
                    booking.VenueId = bookingViewModel.VenueId;
                    booking.BookingDate = bookingViewModel.BookingDate;

                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(bookingViewModel.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            // Repopulate dropdown lists if ModelState is invalid
            ViewData["ClientId"] = new SelectList(_context.Clients, "ClientId", "ClientId", bookingViewModel.ClientId);
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", bookingViewModel.EventId);
            ViewData["VenueId"] = new SelectList(_context.Venues, "VenueId", "VenueId", bookingViewModel.VenueId);

            return View(bookingViewModel);
        }


        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Client)
                .Include(b => b.Event)
                .Include(b => b.Venue)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
