using Domain.Entities;

namespace Application.Interfaces
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task CreateBookingAsync(Booking booking);
    }
}
