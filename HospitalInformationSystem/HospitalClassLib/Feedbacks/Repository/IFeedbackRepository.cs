using HospitalClassLib.Feedbacks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLib.Feedbacks.Repository
{
    public interface IFeedbackRepository
    {
        List<Feedback> GetAll();
        List<Feedback> GetApproved();
        Feedback Get(string id);
        Feedback Update(Feedback feedback);
        Feedback Create(Feedback feedback);
        bool ExistsById(string id);
        bool Delete(string id);
    }
}
