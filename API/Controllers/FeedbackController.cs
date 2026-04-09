using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        //GET: api/feedback
       [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var feedbacks = await _feedbackService.GetAllFeedbacksAsync();
            return Ok(feedbacks);
        }

        // POST: api/feedback
        [HttpPost]
        public async Task<IActionResult> Create(Feedback feedback)
        {
            await _feedbackService.CreateFeedbackAsync(feedback);
            return Ok("Feedback submitted successfully");
        }
    }
}
