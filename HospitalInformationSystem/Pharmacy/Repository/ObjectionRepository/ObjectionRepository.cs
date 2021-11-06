using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository.ObjectionRepository
{
    public class ObjectionRepository : AbstractSqlRepository<Objection, long>, IObjectionRepository
    {
        public ObjectionRepository(MyDbContext dbContext) : base(dbContext)
        {

        }
        protected override long GetId(Objection entity)
        {
            return entity.Id;
        }
    }
}
