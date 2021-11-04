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
        private readonly ObjectionService objectionService;
        private readonly ResponseService responseService;

        public ObjectionController(ObjectionService objectionService, ResponseService responseService)
        {
            this.objectionService = objectionService;
            this.responseService = responseService;
        }

        [HttpGet]
        public List<ObjectionResponseDTO> GetAll()
        {
            return ObjectionMapper.ObjectionResponsesToObjectionResponseDTO(objectionService.GetAll(), responseService.GetAll());
        }
        [HttpPost]
        public Objection Add(ObjectionDTO objectionDTO)
        {
            return objectionService.Add(ObjectionMapper.ObjectionDTOToObjection(objectionDTO));
        }

    }
}
