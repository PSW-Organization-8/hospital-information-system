using System;
using System.Collections.Generic;
using System.Text;
using PharmacyClassLib.Model;

namespace PharmacyClassLib.Repository.RegistratedHospitalRepository
{
    public class RegistratedHospitalRepository : IRegistratedHospitalRepository
    {
        private Dictionary<string, RegistratedHospital> registratedHospitals = new Dictionary<string, RegistratedHospital>();

        public RegistratedHospitalRepository()
        {
            registratedHospitals.Add("Najbolnica", new RegistratedHospital("Najbolnica", "www.neki-sajt.com", "123qwe123"));
        }

        public RegistratedHospital Get(string hospitalName)
        {
            if (registratedHospitals.ContainsKey(hospitalName))
                return registratedHospitals[hospitalName];
            return null;
        }

        public RegistratedHospital Register(RegistratedHospital newHospital)
        {
            if (registratedHospitals.ContainsKey(newHospital.Name))
            {
                return null;
            }
            registratedHospitals.Add(newHospital.Name, newHospital);
            return newHospital;
        }

        public bool IsRegistrated(string apiKey)
        {
            foreach (RegistratedHospital hospital in registratedHospitals.Values)
            {
                if (hospital.ApiKey.Equals(apiKey))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
