using Microsoft.AspNetCore.Mvc;
using PharmacyClassLib.Model;
using PharmacyClassLib.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacyAPI.Filters;

namespace PharmacyAPI.Controllers
{
    [ApiKeyAuth]
    [ApiController]
    [Route("[controller]")]
    public class PharmacyController : ControllerBase
    {
        private readonly IPharmacyService pharmacyService;

        public PharmacyController(IPharmacyService medicationService)
        {
            this.pharmacyService = medicationService;
        }
        [HttpGet]
        public List<Pharmacy> GetAllPharmacies()
        {
            return pharmacyService.GetAll();
        }
    }
}
