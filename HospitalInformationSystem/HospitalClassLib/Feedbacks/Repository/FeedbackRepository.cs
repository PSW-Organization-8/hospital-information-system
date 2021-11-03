using HospitalClassLib.Feedbacks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLib.Feedbacks.Repository
{
    public class FeedbackRepository: AbstractSqlRepository<Feedback, string>, IFeedbackRepository
    {
        private MyDbContext dbContext;

        public FeedbackRepository(MyDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        /*public void ApproveFeedback(string id)
        {
            dbContext.Feedbacks.Where(x =)
        }*/

        public List<Feedback> GetApproved()
        {
            return dbContext.Feedbacks.Where(x => ((x.IsApproved == true) && (x.IsPublishable == true))).ToList();
        }

        protected override string GetId(Feedback entity)
        {
            return entity.Id;
        }
    }
}
