
using HospitalClassLib.HospitalClassLib.Schedule.Model;
using HospitalClassLib.SharedModel;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;


namespace HospitalClassLib.Schedule.Repository.AnamnesisRepository
{
    interface IAnamnesisRepository:IGenericRepository<Anamnesis,String>
    {
        List<Anamnesis> ReadByPatient(Patient patient);
    }
}
