using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class FeedbackRepository : GenericRepository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(AppDbContext context) : base(context)
        {
        }
    }
}
