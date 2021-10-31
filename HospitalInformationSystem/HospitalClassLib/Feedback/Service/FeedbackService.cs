using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalClassLib.Feedback.Model;

namespace HospitalClassLib.Feedback.Service
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


        ObservableCollection<Model.Feedback> feedbacks = new ObservableCollection<Model.Feedback>();

        public Model.Feedback Add(string content)
        {
            Model.Feedback f = new Model.Feedback(content);
            feedbacks.Add(f);
            return f;
        }
    }
}
