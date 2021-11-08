
using HospitalClassLib.MedicalRecords.Repository.SurgeryReportRepo;
using HospitalClassLib.Schedule.Model;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalClassLib.MedicalRecords.Repository.SurgeryReportRepo
{
    public class SurgeryReportFileRepository : GenericFileRepository<string, SurgeryReport, SurgeryReportFileRepository>,ISurgeryReportRepository
    {
        protected override string getKey(SurgeryReport entity)
        {
            return entity.ReportID;
        }

        protected override string getPath()
        {
            return @".\..\..\..\Data\operacijaIzvestaji.json";
        }

        protected override void RemoveReferences(string key)
        {
            throw new NotImplementedException();
        }

        public List<SurgeryReport> ReadByPatient(Patient patient)
        {
            List<SurgeryReport> retVal = new List<SurgeryReport>();

            

            return retVal;
        }

        protected override void ShouldSerialize(SurgeryReport entity)
        {
        }

        
    }
}
