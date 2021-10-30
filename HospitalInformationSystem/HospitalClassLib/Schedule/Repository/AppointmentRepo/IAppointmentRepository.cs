
using System;
using System.Collections.Generic;
using System.Text;

using SIMS.Repositories;
using HospitalClassLib.SharedModel.Enums;
using HospitalClassLib.SharedModel;
using HospitalClassLib.Schedule.Model;

namespace HospitalClassLib.Schedule.Repository.AppointmentRepo
{
    interface IAppointmentRepository : IGenericRepository<Appointment, String>
    {
        List<int> GetAppointmentsCountForCurrentWeek(AppointmentType tip, Doctor l); //nisam siguran da li trebaju da idu u storage class ili u service* */
        List<Appointment> GetPatientAppointments(Patient pacijent);
        List<Appointment> GetDoctorAppointments(Doctor lekar);
    }
}