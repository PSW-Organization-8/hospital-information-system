
using HospitalClassLib.Schedule.Model;
using HospitalClassLib.SharedModel;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalClassLib.MedicalRecords.Repository.SurgeryReportRepo
{
    interface ISurgeryReportRepository:IGenericRepository<SurgeryReport,String>
    {
        List<SurgeryReport> ReadByPatient(Patient p);
    }
}
