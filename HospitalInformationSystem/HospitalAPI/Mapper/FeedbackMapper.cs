using HospitalAPI.Dto;
using HospitalClassLib.Feedbacks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Mapper
{
    public class FeedbackMapper
    {
        public static Feedback FeedbackDtoToFeedback(FeedbackDto dto)
        {
            return new Feedback(dto.Content, dto.IsApproved, DateTime.Now, dto.PatientId);
        }

        public static FeedbackDto FeedbackToFeedbackDto(Feedback feedback)
        {
            return new FeedbackDto(feedback.Content, feedback.IsApproved, feedback.PatientId);
        }
    }
}
