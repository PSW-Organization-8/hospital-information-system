using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalClassLib.SharedModel;

namespace HospitalClassLib.Schedule.Model
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public bool IsApproved { get; set; }
        public bool IsPublishable { get; set; }
        public bool IsAnonymous { get; set; }

        public Feedback(string c) { Id = 1; Content = c; }

        public Feedback() { Id = 1; }

        public Feedback(string content, bool isApproved, DateTime date, Patient patient)
        {
            Content = content;
            IsApproved = isApproved;
            Date = date;
            Patient = patient;
            PatientId = patient.Id;
            IsPublishable = true;
            IsAnonymous = false;
        }


        public Feedback(string content, bool isApproved, DateTime date, Patient patient, bool isPublishable, bool isAnonymous)
        {
            Content = content;
            IsApproved = isApproved;
            Date = date;
            PatientId = 1;
            Patient = patient;
            IsPublishable = isPublishable;
            IsAnonymous = isAnonymous;
        }

    }

}
