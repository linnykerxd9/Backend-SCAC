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
    [Route("api/v1/status")]
    public class StatusController
    {
        private readonly ServiceStatus service;

        public StatusController(ServiceStatus service)
        {
            this.service = service;
        }

        [HttpPost]
        public Task<Status> Create([FromBody] Status item)
        {
            return service.Create(item);
        }

        [HttpGet]
        public List<Status> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Task<Status> GetById([FromRoute] int id)
        {
            return service.GetById(id);
        }

        [HttpPut]
        public Task<Status> UpdateEvent([FromBody] Status item)
        {
            return service.Update(item);
        }

        [HttpDelete]
        public Task<Status> DeleteEvent([FromBody] Status item)
        {
            return service.Delete(item);
        }
    }
}
