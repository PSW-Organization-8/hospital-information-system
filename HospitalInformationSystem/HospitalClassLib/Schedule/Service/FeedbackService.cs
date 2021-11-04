﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalClassLib.Schedule.Model;
using HospitalClassLib.Schedule.Repository.FeedbackRepository;

namespace HospitalClassLib.Schedule.Service
{
    public class FeedbackService
    {
        private static FeedbackService instance = null;
        public static FeedbackService GetInstance()
        {
            if (instance == null)
            {
                instance = new FeedbackService();
            }
            return instance;
        }

        public FeedbackService() { }

        private readonly IFeedbackRepository feedbackRepository;


        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }

        public Feedback Add(Feedback feedback)
        {
            feedback.Id = (GetAll().Count + 1).ToString();
            return feedbackRepository.Create(feedback);
        }

        public List<Feedback> GetAll()
        {
            return feedbackRepository.GetAll();
        }

        public Feedback Get(string id)
        {
            return feedbackRepository.Get(id);
        }

        public Feedback Create(Feedback feedback)
        {
            return feedbackRepository.Create(feedback);
        }

        public bool Delete(string id)
        {
            return feedbackRepository.Delete(id);
        }

        public void ApproveFeedback(string id)
        {
            Feedback feedbackForChange = feedbackRepository.Get(id);
            Feedback feedback = new Feedback(feedbackForChange.Content, true, feedbackForChange.Date, feedbackForChange.PatientId);
            feedback.Id = feedbackForChange.Id;
            feedbackRepository.Update(feedback);
        }

    }
}
