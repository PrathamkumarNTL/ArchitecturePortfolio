using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class FeedbackService :IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;
        public FeedbackService(IFeedbackRepository feedbackRepository) 
        {
            _feedbackRepository = feedbackRepository;
        }

        public async Task<IEnumerable<Feedback>> GetAllFeedbacksAsync()
        {
           return await _feedbackRepository.GetAllAsync();
        }

        public async Task CreateFeedbackAsync(Feedback feedback)
        {
            if(string.IsNullOrWhiteSpace(feedback.Name)) 
                throw new Exception("Name is required.");

            await _feedbackRepository.AddAsync(feedback);
        }
    }
}
