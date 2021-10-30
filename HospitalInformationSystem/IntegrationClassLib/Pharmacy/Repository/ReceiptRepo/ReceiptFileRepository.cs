
using System;
using System.Collections.Generic;
using System.Text;

using SIMS.Repositories;
using HospitalClassLib.SharedModel;

namespace IntegrationClassLib.Pharmacy.Repository.ReceiptRepo
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

        

        protected override void ShouldSerialize(Receipt entity)
        {
            
            
        }
    }
}
