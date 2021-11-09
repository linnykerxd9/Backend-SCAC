using Backend_SCAC.src.Services;
using Microsoft.AspNetCore.Mvc;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Controllers
{
    [ApiController]
    [Route("api/v1/resident")]
    public class ResidentController 
    {
        private readonly ServiceResident service;

        public ResidentController(ServiceResident service)
        {
            this.service = service;
        }

        [HttpPost]
        public Task<Resident> Create([FromBody] Resident item)
        {
            return service.Create(item);
        }

        [HttpGet]
        public List<Resident> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Task<Resident> GetById([FromRoute] int id)
        {
            return service.GetById(id);
        }

        [HttpPut]
        public Task<Resident> UpdateEvent([FromBody] Resident item)
        {
            return service.Update(item);
        }

        [HttpDelete]
        public Task<Resident> DeleteEvent([FromBody] Resident item)
        {
            return service.Delete(item);
        }
    }
}
