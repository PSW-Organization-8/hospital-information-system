using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacyClassLib.Model
{
    public class Pharmacy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id;

        public string Name { get; set; }

        public String APIKey { get; set; }

        public Pharmacy() { }

        public Pharmacy(long Id,string Name,String ApiKey)
        {
            this.Id = Id;
            this.Name = Name;
            this.APIKey = ApiKey;
        }

    }
}
