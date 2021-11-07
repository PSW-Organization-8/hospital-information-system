using PharmacyClassLib.Model.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyClassLib.Model
{
    public class Medication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; }
        public MedicineApprovalStatus Status { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<IngredientQuantity> IngredientQuantities { get; set; }
                
        public Medication(long Id, String Name, MedicineApprovalStatus Status, int Quantity, ICollection<IngredientQuantity> ingradientQuantities)
        {
            this.Id = Id;
            this.Name = Name;
            this.Status = Status;
            this.Quantity = Quantity;
            this.IngredientQuantities = ingradientQuantities;
        }

        public Medication(long Id, String Name, MedicineApprovalStatus Status, int Quantity)
        {
            this.Id = Id;
            this.Name = Name;
            this.Status = Status;
            this.Quantity = Quantity;
            this.IngredientQuantities = new Collection<IngredientQuantity>();
        }

    }
}
