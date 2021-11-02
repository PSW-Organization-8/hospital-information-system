using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacyClassLib.Model
{
    public class MedicationIngradient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; }

        public MedicationIngradient()
        {

        }

        public MedicationIngradient(long Id,String Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
