
using SIMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIMS.DTO
{
    public class SurgeryReportDTO
    {
        

        public String ReportID { get; set; }
        public String DateOfSurgery { get => Surgery.GetAppointmentDate(); }
        public String SurgeryName { get => Report.SurgeryName; }
        public String DoctorName { get => Surgery.Doctor.FullName; }
        public Appointment Surgery { get; set; }
        public SurgeryReport Report { get; set; }

        
    }
}
