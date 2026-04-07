using Domain.Entities;

namespace Application.Interfaces
{
    public interface IFeedbackService
    {
        Task<IEnumerable<Feedback>> GetAllFeedbacksAsync();
        Task CreateFeedbackAsync(Feedback feedback);
    }
}
