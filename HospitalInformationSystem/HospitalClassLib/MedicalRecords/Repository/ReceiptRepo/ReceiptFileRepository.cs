
using HospitalClassLib.Schedule.Model;
using HospitalClassLib.SharedModel;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;


namespace HospitalClassLib.MedicalRecords.Repository.ReceiptRepo
{
    public class ReceiptFileRepository : GenericFileRepository<string, Receipt, ReceiptFileRepository>,IReceiptRepository
    {
        protected override string getKey(Receipt entity)
        {
            return entity.RecieptID;
        }

        protected override void RemoveReferences(string key)
        {
            //throw new NotImplementedException();
        }

        protected override string getPath()
        {
            return @".\..\..\..\Data\recepti.json";
        }

        public List<Receipt> ReadByPatient(Patient patient)
        {
            List<Receipt> retVal = new List<Receipt>();

            foreach (Receipt r in this.GetAll())
            {
                if (r.Patient.Jmbg == patient.Jmbg)
                    retVal.Add(r);
            }

            return retVal;
        }

        protected override void ShouldSerialize(Receipt entity)
        {
            
            
        }
    }
}
