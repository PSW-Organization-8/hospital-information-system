using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalClassLib.SharedModel;

namespace HospitalClassLib.Feedbacks.Model
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Content { get; set; }
        public string PatientId { get; set; }
        public DateTime Date { get; set; }
        public bool IsApproved { get; set; }
        public bool IsPublishable { get; set; }
        public bool IsAnonymous { get; set; }





        public Feedback(string c) { Id = "1"; Content = c; }
        public Feedback() { Id = "1"; }
        public Feedback(string content, bool isApproved, DateTime date, string patientId)
        {
            this.Content = content;
            this.IsApproved = isApproved;
            this.Date = date;
            this.PatientId = patientId;
            this.IsPublishable = true;
            this.IsAnonymous = true;
        }

        /*public Feedback(string content, bool isApproved, DateTime date, string patientId, bool isPublishable, bool isAnonymous)
        {
            this.Content = content;
            this.IsApproved = isApproved;
            this.Date = date;
            this.PatientId = patientId;
            this.IsPublishable = isPublishable;
            this.IsAnonymous = isAnonymous;
        }
        */
    }

}
