using System;
using System.Collections.Generic;
using System.Text;
using PharmacyClassLib.Model;

namespace PharmacyClassLib.Repository.RegistratedHospitalRepository
{
    public interface IRegistratedHospitalRepository : IGenericRepository<RegistratedHospital, string>
    {
        bool ExistsByApiKey(string apiKey);
    }
}
