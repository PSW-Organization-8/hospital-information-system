using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository
{
    public class MedicationRepository : AbstractSqlRepository<Medication, long>, IMedicationRepository
    {
        public MedicationRepository(MyDbContext dbContext) : base(dbContext)
        {

        }

        protected override long GetId(Medication entity)
        {
            return entity.Id;
        }
    }
}
