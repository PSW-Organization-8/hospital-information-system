using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAPI.Dto;
using HospitalAPI.Mapper;
using System.Collections.ObjectModel;
using HospitalClassLib.Schedule.Model;
using HospitalClassLib.Schedule.Repository.FeedbackRepository;
using HospitalClassLib.Schedule.Service;

namespace HospitalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly FeedbackService feedbackService;
        private readonly FeedbackRepository feedbackRepository;

        public FeedbackController(FeedbackService feedbackService, FeedbackRepository feedbackRepository)
        {

            this.feedbackService = feedbackService;
            this.feedbackRepository = feedbackRepository;
        }

        [HttpGet]
        [Route("approved")]
        public IActionResult GetApprovedFeedbacks() 
        {
            List<Feedback> feedbacks = feedbackRepository.GetApproved();
            if (feedbacks == null || feedbacks.Count == 0)
            {
                return BadRequest();
            }
            return Ok(feedbackRepository.GetApproved());
        }

        [HttpGet]
        public List<Feedback> GetFeedbacks()
        {
            return feedbackService.GetAll();
        }

        [HttpGet("{id?}")]
        public IActionResult GetFeedback(string id)
        {
            if (id == null || id == "")
            {
                return BadRequest();
            }
            else
            {
                return Ok(feedbackService.Get(id));
            }
        }

        [HttpPost]
        public IActionResult AddFeedback(FeedbackDto feedbackDto)
        {
            if (feedbackDto == null || feedbackDto.Content == "")
            {
                return BadRequest();
            }
            else
            {
                return Ok(feedbackService.Create(FeedbackMapper.FeedbackDtoToFeedback(feedbackDto)));
            }

        }

        [HttpDelete("{id?}")]
        public IActionResult DeleteFeedback(string id)
        {
            if (id == null || id == "")
            {
                return BadRequest();
            }
            else
            {
                return Ok(feedbackService.Delete(id));
            }
        }


        [HttpPut("{id}")]
        public void ApproveFeedback(string id)
        {
            feedbackService.ApproveFeedback(id);
        }
    }
}
