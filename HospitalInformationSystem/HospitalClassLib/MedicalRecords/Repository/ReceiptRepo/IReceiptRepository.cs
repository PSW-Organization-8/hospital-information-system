
using HospitalClassLib.Schedule.Model;
using HospitalClassLib.SharedModel;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalClassLib.MedicalRecords.Repository.ReceiptRepo
{
    interface IReceiptRepository:IGenericRepository<Receipt,String>
    {
        List<Receipt> ReadByPatient(Patient p);
    }
}
