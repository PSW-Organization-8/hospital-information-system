using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacyAPI.Dto;
using PharmacyClassLib.Model;

namespace PharmacyAPI.Mapper
{
    public class RegistratedHospitalMapper
    {
        public static RegistratedHospital RegistratedHospitalDtoToRegistratedHospital(RegistratedHospitalDto dto)
        {
            return new RegistratedHospital(dto.Name, dto.Url, dto.ApiKey);
        }

        public static RegistratedHospitalDto RegistratedHospitalToRegistratedHospitalDto(
            RegistratedHospital rh)
        {
            return new RegistratedHospitalDto(rh.Name, rh.Url, rh.ApiKey);
        }
    }
}
