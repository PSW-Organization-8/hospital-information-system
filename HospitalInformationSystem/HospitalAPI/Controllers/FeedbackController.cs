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
using HospitalClassLib.Feedbacks.Repository;

namespace HospitalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly FeedbackService feedbackService;
        private FeedbackRepository feedbackRepository;

        public FeedbackController(FeedbackService feedbackService, FeedbackRepository feedbackRepository)
        {

            this.feedbackService = feedbackService;
            this.feedbackRepository = feedbackRepository;
        }
        /*
        [HttpGet]
        public ObservableCollection<Feedback> GetAll()
        {
            return FeedbackService.GetInstance().GetAll();
        }
        [HttpPost]
        public Feedback Add(FeedbackDto feedbackDto)
        {   
            return FeedbackService.GetInstance().Add(FeedbackMapper.FeedbackDtoToFeedback(feedbackDto));
        }*/

        [HttpPut("{id}")]
        public void ApproveFeedback(string id)
        {
            feedbackService.ApproveFeedback(id);
        }

        [HttpGet]
        [Route("approved")]
        public List<Feedback> GetApprovedFeedbacks() 
        {
            return feedbackRepository.GetApproved();
        }

        [HttpGet]
        public List<Feedback> GetUsers()
        {
            return feedbackService.Get();
        }

        [HttpGet("{id?}")]
        public Feedback GetUser(string id)
        {
            return feedbackService.Get(id);
        }

        [HttpPost]
        public Feedback AddUser(FeedbackDto feedbackDto)
        {
            return feedbackService.Create(FeedbackMapper.FeedbackDtoToFeedback(feedbackDto));
        }

        [HttpDelete("{id?}")]
        public bool DeleteUser(string id)
        {
            return feedbackService.Delete(id);
        }
    }
}
