using IntegrationAPI.Dto;
using IntegrationClassLib.Pharmacy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPI.Mapper
{
    public class PharmacyMapper
    {
        public static Pharmacy PharmacyDtoToPharmacy(PharmacyDto pharmacyDto)
        {
            return new Pharmacy(pharmacyDto.Name, pharmacyDto.ApiKey, pharmacyDto.Url, pharmacyDto.Port);
        }
        public static PharmacyDto PharmacyToPharmacyDto(Pharmacy pharmacy)
        {
            return new PharmacyDto(pharmacy.Name, pharmacy.ApiKey, pharmacy.Url, pharmacy.Port);
        }
    }
}
