
using System;
using System.Collections.Generic;
using System.Text;


namespace HospitalClassLib.SharedModel
{
    public class Receipt
    {
        

        public String MedicineName { get; set; }
        public String Amount { get; set; }
        public String Diagnosis { get; set; }
        public String RecieptID { get; set; }
        //public Doctor Doctor { get; set; } nisam siguran da li vam ovo treba
        //public Patient Patient { get; set; }
        public DateTime Date { get; set; }

        public Receipt()
        {
            RecieptID = DateTime.Now.ToString("yyMMddhhmmss");
        }

        public Receipt( String medicineName, String amount, String diagnosis)
        {
            
            MedicineName = medicineName;
            Amount = amount;
            Diagnosis = diagnosis;

            RecieptID = DateTime.Now.ToString("yyMMddhhmmss");
            Date = DateTime.Today;

        }   


        

        

    }
}
