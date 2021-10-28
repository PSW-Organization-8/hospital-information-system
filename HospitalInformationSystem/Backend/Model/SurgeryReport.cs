using SIMS.Repositories.SecretaryRepo;
using System;
using System.Collections.Generic;
using System.Text;
using SIMS.Repositories.AppointmentRepo;
using SIMS.Repositories.DoctorRepo;
using SIMS.Service.AppointmentServices;

namespace SIMS.Model
{
    public class SurgeryReport
    {
        private AppointmentService appointmentController = new AppointmentService();

        public DateTime DateOfReport { get; set; }
        public String ReportID { get; set; }
        public String SurgeryName { get; set; }
        public String SurgeryDescription { get; set; }

        public SurgeryReport()
        {
            DateOfReport = DateTime.Today;
        }

        public SurgeryReport(Appointment surgery, String surgeryName, String surgeryDescription)
        {
            DateOfReport = DateTime.Today;
            SurgeryName = surgeryName;
            SurgeryDescription = surgeryDescription;
            ReportID = surgery.AppointmentID;
        }

        public Appointment GetSurgery()
        {
            return appointmentController.GetAppointment(ReportID);
        }

    }
}
