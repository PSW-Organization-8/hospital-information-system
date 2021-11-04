using System;
using System.Collections.Generic;
using System.Text;
using PharmacyClassLib.Model;

namespace PharmacyClassLib.Repository.RegistratedHospitalRepository
{
    public class RegistratedHospitalRepository : AbstractSqlRepository<RegistratedHospital, string>, IRegistratedHospitalRepository
    {
        public RegistratedHospitalRepository(MyDbContext dbContext) : base(dbContext)
        {

        }

        protected override string GetId(RegistratedHospital entity)
        {
            return entity.Name;
        }
    }
}
