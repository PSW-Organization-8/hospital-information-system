using Microsoft.AspNetCore.Mvc;
using PharmacyClassLib.Model;
using PharmacyClassLib.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PharmacyController
    {
        private readonly IPharmacyService pharmacyService;

        public PharmacyController(IPharmacyService medicationService)
        {
            this.pharmacyService = medicationService;
        }
        [HttpGet]
        public List<Pharmacy> Get()
        {
            return pharmacyService.Get();
        }
    }
}
