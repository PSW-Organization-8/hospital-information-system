
using System;
using System.Collections.Generic;
using System.Text;

using SIMS.Repositories;
using HospitalClassLib.SharedModel;

namespace IntegrationClassLib.Pharmacy.Repository.ReceiptRepo
{
    interface IReceiptRepository:IGenericRepository<Receipt,String>
    {
        //List<Receipt> ReadByPatient(Patient p);
    }
}
