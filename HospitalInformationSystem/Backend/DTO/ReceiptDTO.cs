using System;
using System.Collections.Generic;
using System.Text;
using SIMS.Model;
using SIMS.Service;

namespace SIMS.DTO
{
    public class ReceiptDTO
    {
        private ReceiptService receiptController = new ReceiptService();

        public String DoctorName { get; }
        public String DateString { get;  }
        public String MedicationNameAmount { get; }
        public Receipt Receipt { get; set; } 

        public ReceiptDTO(Receipt receipt)
        {
            Receipt = receiptController.GetReceipt(receipt.RecieptID);
            Receipt.InitData();
            DoctorName = Receipt.Doctor.FullName;
            DateString = receipt.GetRecieptDateString();
            MedicationNameAmount = Receipt.MedicineName + ", " + Receipt.Amount;
        }

    }
}
