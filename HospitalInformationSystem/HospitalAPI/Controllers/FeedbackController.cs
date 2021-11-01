using HospitalClassLib.Feedbacks.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalClassLib.Feedbacks.Service;
using HospitalAPI.Dto;
using HospitalAPI.Mapper;
using System.Collections.ObjectModel;

namespace HospitalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ILogger<FeedbackController> _logger;
        public FeedbackController(ILogger<FeedbackController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ObservableCollection<Feedback> GetAll()
        {
            return FeedbackService.GetInstance().GetAll();
        }
        [HttpPost]
        public Feedback Add(FeedbackDto feedbackDto)
        {   
            return FeedbackService.GetInstance().Add(FeedbackMapper.FeedbackDtoToFeedback(feedbackDto));
        }
        [HttpPut("{id}")]
        public void ApproveFeedback(string id)
        {
            FeedbackService.GetInstance().ApproveFeedback(id);
        }

        [HttpGet]
        [Route("approved")]
        public ObservableCollection<Feedback> GetApprovedFeedbacks() 
        {
            return FeedbackService.GetInstance().GetApprovedFeedbacks();
        }
    }
}
