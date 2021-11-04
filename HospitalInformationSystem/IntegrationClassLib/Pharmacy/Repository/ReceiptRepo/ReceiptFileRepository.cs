
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

        public Receipt Get(string id)
        {
            throw new NotImplementedException();
        }

        Receipt IGenericRepository<Receipt, string>.Update(Receipt t)
        {
            throw new NotImplementedException();
        }

        public Receipt Create(Receipt t)
        {
            throw new NotImplementedException();
        }

        public bool ExistsById(string id)
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Receipt, string>.Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
