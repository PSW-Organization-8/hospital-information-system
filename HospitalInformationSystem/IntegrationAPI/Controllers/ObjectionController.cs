using IntegrationAPI.Dto;
using IntegrationAPI.Mapper;
using IntegrationClassLib.Parthership.Model;
using IntegrationClassLib.Parthership.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectionController : ControllerBase
    {

        private readonly ILogger<ObjectionController> _logger;
        public ObjectionController(ILogger<ObjectionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ObservableCollection<Objection> GetAll()
        {
            return ObjectionService.GetInstance().GetAll();
        }
        [HttpPost]
        public Objection Add(ObjectionDTO objectionDTO)
        {
            return ObjectionService.GetInstance().Add(ObjectionMapper.ObjectionDTOToObjection(objectionDTO));
        }

    }
}
