using PharmacyClassLib.Model;
using PharmacyClassLib.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Service
{
    public class MedicationService : IMedicationService
    {
        private readonly IMedicationRepository medicationRepository;

        public MedicationService(IMedicationRepository medicationRepository)
        {
            this.medicationRepository = medicationRepository;
        }

        public List<Medication> GetAll()
        {
            return medicationRepository.GetAll();
        }
    }
}
