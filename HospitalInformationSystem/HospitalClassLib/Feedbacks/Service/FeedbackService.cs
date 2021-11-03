using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalClassLib.Feedbacks.Model;
using HospitalClassLib.Feedbacks.Repository;

namespace HospitalClassLib.Feedbacks.Service
{
    public class FeedbackService
    {
        //ObservableCollection<Feedback> feedbacks = new ObservableCollection<Feedback>();
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
        /*public Feedback Add(Feedback feedback)
        {
            feedback.Id = (feedbacks.Count + 1).ToString();
            feedbacks.Add(feedback);
            return feedback;
        }
        public ObservableCollection<Feedback> GetAll()
        {
            return feedbacks;
        }
        public void ApproveFeedback(string feedbackId)
        {
            foreach(Feedback feedback in this.feedbacks)
            {
                if (feedback.Id.Equals(feedbackId))
                    feedback.IsApproved = true;
            }
        }

        public ObservableCollection<Feedback> GetApprovedFeedbacks()
        {
            ObservableCollection<Feedback> approvedFeedbacks = new ObservableCollection<Feedback>();
            foreach (Feedback feedback in this.feedbacks)
            {
                if (feedback.IsApproved)
                    approvedFeedbacks.Add(feedback);
            }
            return approvedFeedbacks;
        }*/

        private readonly IFeedbackRepository feedbackRepository;


        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }

        public List<Feedback> Get()
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
            Feedback feedback = feedbackRepository.Get(id);
            feedback.IsApproved = true;
            feedbackRepository.Update(feedback);
        }

        public Feedback Add(Feedback feedback)
        {
            feedback.Id = (feedbackRepository.GetAll().ToList().Count() + 1).ToString();
            return feedbackRepository.Create(feedback);
        }
    }
}
