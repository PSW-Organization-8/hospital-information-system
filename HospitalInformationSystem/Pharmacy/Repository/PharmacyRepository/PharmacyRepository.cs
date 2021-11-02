using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository
{
    public class PharmacyRepository : IPharmacyRepository
    {
        public List<Pharmacy> Get()
        {
            List<Pharmacy> pharmacies = new List<Pharmacy>();
            pharmacies.Add(new Pharmacy(1, "Apoteka Jankovic", "123456789"));
            pharmacies.Add(new Pharmacy(2, "Gradska Apoteka", "123486313081"));
            pharmacies.Add(new Pharmacy(3, "Apoteka Matovic", "456753"));
            return pharmacies;
        }
    }
}
