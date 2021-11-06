using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacyClassLib.Model
{
    public class Objection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }        
        public long ObjectionIdFromHospitalDatabase { get; set; }
        public string HopsitalName { get; set; }
        public string TextObjection { get; set; }

        public Objection() { }

        public Objection(long id, long objectioHospitalId, string text, string name)
        {

            TextObjection = text;
            HopsitalName = name;
            Id = id;
            ObjectionIdFromHospitalDatabase = objectioHospitalId;
        }

        public Objection(long objectioHospitalId, string text, string name)
        {

            TextObjection = text;
            HopsitalName = name;
            ObjectionIdFromHospitalDatabase = objectioHospitalId;
        }
    }
}
