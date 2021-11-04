using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository
{
    public class PharmacyRepository : AbstractSqlRepository<Pharmacy, long>, IPharmacyRepository
    {
        public PharmacyRepository(MyDbContext dbContext) : base(dbContext)
        {

        }

        protected override long GetId(Pharmacy entity)
        {
            return entity.Id;
        }
    }
}
