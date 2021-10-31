using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalClassLib.SharedModel;

namespace HospitalClassLib.Feedback.Model
{
    public class Feedback
    {
        public string Id { get; set; }
        public string Content { get; set; }

        public Patient Patient { get; set; }


        public Feedback(string c) { Id = "1"; Content = c; }
        public Feedback() { Id = "1"; }
    }

}
