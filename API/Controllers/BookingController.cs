using Application.DTOs.Booking;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;
        public BookingController(IBookingService bookingService,IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        // GET: api/booking
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookings = await _bookingService.GetAllBookingsAsync();
            return Ok(bookings);
        }

        // POST: api/booking
        [HttpPost]
        public async Task<IActionResult> Create(CreateBookingDto dto)
        {
            var booking = _mapper.Map<Booking>(dto);
            await _bookingService.CreateBookingAsync(booking);
            return Ok("Booking created successfully");
        }
    }
}
