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
        public long Id { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string AdressNumber { get; set; }

        public Pharmacy() { }

        public Pharmacy(long id, string name, string city, string adress, string adressNumber)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
            this.Adress = adress;
            this.AdressNumber = adressNumber;
        }

    }
}
