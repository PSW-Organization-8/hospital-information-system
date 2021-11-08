using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacyClassLib.Model
{
    public class IngredientQuantity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double Amount { get; set; }
        public long MedicationId { get; set; }

        public IngredientQuantity(int Id, double Amount, long MedicationId)
        {
            this.Id = Id;
            this.Amount = Amount;
            this.MedicationId = MedicationId;
        }

    }
}
