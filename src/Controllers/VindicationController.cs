using Backend_SCAC.src.Services;
using Microsoft.AspNetCore.Mvc;
using SCACback.src.DTO;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Controllers
{
    [ApiController]
    [Route("api/v1/vindication")]
    public class VindicationController
    {
        private readonly ServiceVindication service;

        public VindicationController(ServiceVindication service)
        {
            this.service = service;
        }

        [HttpPost]
        public Task<VindicationDTO> Create([FromBody] Vindication item)
        {
            return service.Create(item);
        }

        [HttpGet]
        public List<Vindication> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Task<Vindication> GetById([FromRoute] int id)
        {
            return service.GetById(id);
        }

        [HttpPut]
        public Task<VindicationDTO> UpdateEvent([FromBody] Vindication item)
        {
            return service.Update(item);
        }

        [HttpDelete]
        public Task<VindicationDTO> DeleteEvent([FromBody] Vindication item)
        {
            return service.Delete(item);
        }
    }
}
