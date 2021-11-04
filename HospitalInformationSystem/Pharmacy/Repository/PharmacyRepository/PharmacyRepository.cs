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
            pharmacies.Add(new Pharmacy(1, "Jankovic", "Novi Sad", "Rumenačka", "15"));
            pharmacies.Add(new Pharmacy(2, "Jankovic", "Novi Sad", "Bulevar oslobođenja", "135"));
            pharmacies.Add(new Pharmacy(3, "Jankovic", "Beograd", "Olge Jovanović", "18a"));
            return pharmacies;
        }
    }
}
