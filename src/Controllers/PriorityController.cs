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
    [Route("api/v1/priority")]
    public class PriorityController
    {
        private readonly ServicePriority service;

        public PriorityController(ServicePriority service)
        {
            this.service = service;
        }

        [HttpPost]
        public Task<Priority> Create([FromBody] Priority item)
        {
            return service.Create(item);
        }

        [HttpGet]
        public List<Priority> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Task<Priority> GetById([FromRoute] int id)
        {
            return service.GetById(id);
        }

        [HttpPut]
        public Task<Priority> UpdateEvent([FromBody] Priority item)
        {
            return service.Update(item);
        }

        [HttpDelete]
        public Task<Priority> DeleteEvent([FromBody] Priority item)
        {
            return service.Delete(item);
        }
    }
}
