﻿using HospitalClassLib.SharedModel;
using HospitalClassLib.SharedModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLib.Schedule.Model
{

    public class Patient : LoggedUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //public SexType PatientGender { get; set; }
        //public BloodType BloodType { get; set; }
        public bool IsBanned { get; set; }
        public string Lbo { get; set; }
        public bool Guest { get; set; }
        //public List<Component> Allergens { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public List<string> HronicalDiseases { get; set; }
        //public Doctor ChosenDoctor { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        /*public Patient() { }

        public Patient(int id, string name, string lastName, string jmbg, string username, string password, DateTime dateOfBirth)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Jmbg = jmbg;
            this.Username = username;
            this.Password = password;
            this.DateOfBirth = dateOfBirth;
        }*/

        /*public Patient(string name, string lastName, string jmbg, string username, string password, string email, string phone, Address address, string lbo, bool guest, List<Component> allergens) : base(name, lastName, jmbg, username, password, email, phone, address)
        {
            Lbo = lbo;
            Guest = guest;
            Allergens = allergens;
            IsBanned = false;
        }*/

        /*public Patient(string name, string lastName, string jmbg, string username, string password, string email, string phone, Address address, string lbo, bool guest, List<Component> allergens, DateTime dateOfBirth, BloodType bloodType, SexType gender, List<string> hronicalDiseases) : base(name, lastName, jmbg, username, password, email, phone, address)
        {
            Lbo = lbo;
            Guest = guest;
            Allergens = allergens;
            DateOfBirth = dateOfBirth;
            BloodType = bloodType;
            PatientGender = gender;
            HronicalDiseases = hronicalDiseases;
            IsBanned = false;
        }*/

        /*public Patient(Patient patient)
        {
            Name = patient.Name;
            LastName = patient.LastName;
            Jmbg = patient.Jmbg;
            Username = patient.Username;
            Password = patient.Password;
            Email = patient.Email;
            Phone = patient.Phone;
            Address = patient.Address;

            Lbo = patient.Lbo;
            Guest = patient.Guest;
            Allergens = patient.Allergens;
            DateOfBirth = patient.DateOfBirth;
            BloodType = patient.BloodType;
            PatientGender = patient.PatientGender;
            HronicalDiseases = patient.HronicalDiseases;
            IsBanned = patient.IsBanned;
        }

        public Patient() : base()
        {
            IsBanned = false;
        }

        public Patient(string name, string lastName, string jmbg) : base(name, lastName, jmbg, "", "", "", "", new Address("", "", new City("", 0, new Country(""))))
        {
            Lbo = "";
            Guest = true;
            Allergens = new List<Component>();
            DateOfBirth = DateTime.MinValue;
            BloodType = BloodType.Op;
            PatientGender = SexType.Male;
            HronicalDiseases = new List<string>();
        }

        public void SetAttributes(Patient p)
        {
            Name = p.Name;
            LastName = p.LastName;
            Jmbg = p.Jmbg;
            Username = p.Username;
            Password = p.Password;
            Email = p.Email;
            Phone = p.Phone;
            Address = p.Address;
            Lbo = p.Lbo;
            Guest = p.Guest;
        }



        public bool Unavailable(Appointment appointment)
        {
            return appointment.Patient.Jmbg == Jmbg;
        }

        public string GetDateOfBirthString()
        {
            return DateOfBirth.ToString("dd.MM.yyyy.");
        }

        public string GetGenderString()
        {
            if (PatientGender == SexType.Male)
                return "Muško";
            else
                return "Žensko";
        }

        public string GetBloodTypeString()
        {
            if (BloodType == BloodType.ABn)
                return "AB-";
            else if (BloodType == BloodType.ABp)
                return "AB+";
            else if (BloodType == BloodType.Ap)
                return "A+";
            else if (BloodType == BloodType.An)
                return "A-";
            else if (BloodType == BloodType.Bp)
                return "B+";
            else if (BloodType == BloodType.Bn)
                return "B-";
            else if (BloodType == BloodType.Op)
                return "O+";
            else if (BloodType == BloodType.On)
                return "O-";

            return null;
        }

        public bool IsAlergic(Medication medicine)
        {
            foreach (Component a in Allergens)
            {
                //if (lek.Components.Contains(a))
                foreach (Component component in medicine.Components)
                    if (component.ID == a.ID)
                        return true;
            }
            return false;
        }

        public string GetHronicalDiseases()
        {
            string hronBolestiString = "";
            if (HronicalDiseases.Count == 0 || HronicalDiseases.Contains(""))
                return "Nema";

            foreach (string a in HronicalDiseases)
                hronBolestiString += a + ", ";
            return hronBolestiString.Remove(hronBolestiString.Length - 2);
        }*/
    }
}
