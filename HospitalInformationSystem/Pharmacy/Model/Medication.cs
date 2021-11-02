using PharmacyClassLib.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacyClassLib.Model
{
    public class Medication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name;

        public MedicineApprovalStatus Status { get; set; }

        public int Quantity;

        public virtual ICollection<IngradientQuantity> ingradientQuantities { get; set; }

        
        public Medication(long Id,String Name,MedicineApprovalStatus status,int Quantity,ICollection<IngradientQuantity> ingradientQuantities)
        {
            this.Id = Id;
            this.Name = Name;
            this.Status = Status;
            this.Quantity = Quantity;
            this.ingradientQuantities = ingradientQuantities;
        }




    }
}
