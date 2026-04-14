using Application.DTOs.Feedback;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;
        private readonly IMapper _mapper;

        public FeedbackController(IFeedbackService feedbackService,IMapper mapper)
        {
            _feedbackService = feedbackService;
            _mapper = mapper;
        }

        //GET: api/feedbackh
       [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var feedbacks = await _feedbackService.GetAllFeedbacksAsync();
            return Ok(feedbacks);
        }

        // POST: api/feedback
        [HttpPost]
        public async Task<IActionResult> Create(CreateFeedbackDto dto)
        {
            var feedback = _mapper.Map<Feedback>(dto);
            await _feedbackService.CreateFeedbackAsync(feedback);
            return Ok("Feedback submitted successfully");
        }
    }
}
