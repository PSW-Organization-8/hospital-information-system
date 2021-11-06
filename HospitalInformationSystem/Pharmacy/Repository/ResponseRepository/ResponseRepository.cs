using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository.ResponseRepository
{
    public class ResponseRepository : AbstractSqlRepository<Response, long>, IResponseRepository
    {
        public ResponseRepository(MyDbContext dbContext) : base(dbContext)
        {

        }
        protected override long GetId(Response entity)
        {
            return entity.Id;
        }
    }
}
