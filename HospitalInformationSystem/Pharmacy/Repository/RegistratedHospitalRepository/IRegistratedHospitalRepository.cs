using System;
using System.Collections.Generic;
using System.Text;
using PharmacyClassLib.Model;

namespace PharmacyClassLib.Repository.RegistratedHospitalRepository
{
    public interface IRegistratedHospitalRepository
    {
        RegistratedHospital Get(string hospitalName);
        RegistratedHospital Register(RegistratedHospital newHospital);
    }
}
