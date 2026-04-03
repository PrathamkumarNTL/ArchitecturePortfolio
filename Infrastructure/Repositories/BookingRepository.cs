using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
