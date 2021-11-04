using HospitalClassLib.Schedule.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLib.Schedule.Repository.FeedbackRepository
{
    public class FeedbackRepository : AbstractSqlRepository<Feedback, string>, IFeedbackRepository
    {
        private MyDbContext dbContext;

        public FeedbackRepository(MyDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Feedback> GetApproved()
        {
            return dbContext.Feedbacks.Where(x => x.IsApproved && x.IsPublishable).ToList();
        }

        protected override string GetId(Feedback entity)
        {
            return entity.Id;
        }
    }
}
