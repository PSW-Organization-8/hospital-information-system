using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Service.Interface
{
    interface IMedicationIngredientService
    {
        List<MedicationIngredient> GetAll();
    }
}
