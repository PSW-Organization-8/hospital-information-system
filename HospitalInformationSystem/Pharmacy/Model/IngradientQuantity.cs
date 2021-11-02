using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacyClassLib.Model
{
    public class IngradientQuantity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double Amount { get; set; }

        public  long MedicationId { get; set; }

        public virtual MedicationIngradient MediactionIngradient { get; set; }

        public IngradientQuantity(int Id,double Amount,long MedicationId)
        {
            this.Id = Id;
            this.Amount = Amount;
            this.MedicationId = MedicationId;
        }
    }
}
