using HospitalClassLib.Schedule.Model;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;


namespace HospitalClassLib.Schedule.Repository.AppointmentLogRepo
{
    interface IAppointmentLogRepository:IGenericRepository<AppointmentLog,String>
    {
        
    }
}
