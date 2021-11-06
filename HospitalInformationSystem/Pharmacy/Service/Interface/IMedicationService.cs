using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Service
{
    public interface IMedicationService
    {
        List<Medication> GetAll();
    }
}
