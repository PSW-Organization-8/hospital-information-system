using System;
using System.Collections.Generic;

namespace IntegrationClassLib.Pharmacy.Service
{
    public class PharmacyService
    {
        List<Model.Pharmacy> pharmacies = new List<Model.Pharmacy>();

        private static PharmacyService instance = null;
        public static PharmacyService GetInstance()
        {
            if (instance == null)
            {
                instance = new PharmacyService();
            }
            return instance;
        }

        public Model.Pharmacy Add(Model.Pharmacy pharmacy)
        {
            pharmacies.Add(pharmacy);
            return pharmacy;
        }

        public List<Model.Pharmacy> GetAll()
        {
            return pharmacies;
        }
    }
}
