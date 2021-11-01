using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Dto
{
    public class FeedbackDto
    {

        public string Content { get; set; }

        public bool IsApproved { get; set; }

        public string PatientId { get; set; }

        public FeedbackDto() { }

        public FeedbackDto(string content, bool isApproved, string patientId) {
            this.Content = content;
            this.IsApproved = isApproved;
            this.PatientId = patientId;
        }
    }
}
