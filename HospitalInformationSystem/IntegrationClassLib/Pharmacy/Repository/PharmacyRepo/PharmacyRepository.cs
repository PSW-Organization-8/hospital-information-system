using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationClassLib.Pharmacy.Repository.PharmacyRepo
{
    public class PharmacyRepository : AbstractSqlRepository<Pharmacy.Model.Pharmacy, long>, IPharmacyRepository
    {
        public PharmacyRepository(MyDbContext dbContext) : base(dbContext)
        {

        }

        protected override long GetId(Model.Pharmacy entity)
        {
            return entity.Id;
        }
    }
}
