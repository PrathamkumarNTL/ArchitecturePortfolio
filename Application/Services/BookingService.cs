using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class BookingService :IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _bookingRepository.GetAllAsync();
        }

        public async Task CreateBookingAsync(Booking booking)
        {
            if(booking.BookingDate < DateTime.UtcNow)
                throw new Exception("Booking date cannot be in the past.");

            await _bookingRepository.AddAsync(booking);
        }
    }
}
