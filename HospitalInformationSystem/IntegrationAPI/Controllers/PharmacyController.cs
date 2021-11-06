using IntegrationAPI.Dto;
using IntegrationAPI.Mapper;
using IntegrationClassLib.Pharmacy.Model;
using IntegrationClassLib.Pharmacy.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace IntegrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly PharmacyService pharmacyService;

        public PharmacyController(PharmacyService pharmacyService)
        {
            this.pharmacyService = pharmacyService;
        }

        [HttpGet]
        public List<Pharmacy> GetAll()
        {
            return pharmacyService.GetAll();
        }

        [HttpPost]
        public Pharmacy Add(PharmacyDto pharmacyDto)
        {
            return pharmacyService.Add(PharmacyMapper.PharmacyDtoToPharmacy(pharmacyDto));
        }

    }
}
