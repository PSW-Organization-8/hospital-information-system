using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacyClassLib.Model;
using PharmacyAPI.Dto;
using PharmacyAPI.Mapper;
using PharmacyClassLib.Service;

namespace PharmacyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalRegistrationController : ControllerBase
    {
        private readonly IHospitalRegistrationService hospitalRegistrationService;

        public HospitalRegistrationController(IHospitalRegistrationService hospitalRegistrationService)
        {
            this.hospitalRegistrationService = hospitalRegistrationService;
        }

        [HttpGet] //hospitalRegistration?hospitalName=ime
        public RegistratedHospital Get(string? hospitalName)
        {
            return hospitalRegistrationService.Get(hospitalName);
        }

        [HttpPost]
        public RegistratedHospital Register(RegistratedHospitalDto newHospitalDto)
        {
            return hospitalRegistrationService.Register(
                RegistratedHospitalMapper.RegistratedHospitalDtoToRegistratedHospital(newHospitalDto));
        }
    }
}
