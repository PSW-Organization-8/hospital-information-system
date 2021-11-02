using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository
{
    public class MedicationRepository:IMedicationRepository
    {
        public List<Medication> Get()
        {
            return getMedications();

        }

        private List<MedicationIngradient> GetIngraddents()
        {
            List<MedicationIngradient> ingradients = new List<MedicationIngradient>();
            MedicationIngradient ingradient1 = new MedicationIngradient(1,"Vitamin C");
            MedicationIngradient ingradient2 = new MedicationIngradient(2, "Fosfor");
            MedicationIngradient ingradient3 = new MedicationIngradient(3, "Kalcijum");
            ingradients.Add(ingradient1);
            ingradients.Add(ingradient2);
            ingradients.Add(ingradient3);
            return ingradients;
        }
        private List<IngradientQuantity> IngradientsQuantity()
        {
            List<IngradientQuantity> quantities = new List<IngradientQuantity>();
            IngradientQuantity  quantit= new IngradientQuantity(1, 20, 1);
            IngradientQuantity quantity2 = new IngradientQuantity(2, 30, 4);
            quantities.Add(quantit);
            quantities.Add(quantity2);
            return quantities;
        }

        private List<Medication> getMedications()
        {
            Medication m = new Medication(1, "Paracetamol", Model.Enums.MedicineApprovalStatus.Accepted, 150, IngradientsQuantity());
            Medication m2 = new Medication(2, "Analgin", Model.Enums.MedicineApprovalStatus.Accepted, 50, IngradientsQuantity());
            List<Medication> medications = new List<Medication>();
            medications.Add(m);
            medications.Add(m2);
            return medications;
        }
    }
}
