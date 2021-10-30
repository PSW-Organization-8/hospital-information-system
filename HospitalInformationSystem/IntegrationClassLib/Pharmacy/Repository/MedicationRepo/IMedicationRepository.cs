using System;
using System.Collections.Generic;
using System.Text;
using IntegrationClassLib.Pharmacy.Model;
using SIMS.Repositories;

namespace IntegrationClassLib.Pharmacy.Repository.MedicationRepo
{
    interface IMedicationRepository:IGenericRepository<Medication,String>
    {
        List<Medication> GetApprovedMedicine();
        List<Medication> GetMedicineWaitingForApproval();
        List<Medication> GetDeniedMedicine();
    }
}
