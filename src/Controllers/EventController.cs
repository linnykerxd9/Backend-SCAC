using Backend_SCAC.src.Services;
using Microsoft.AspNetCore.Mvc;
using SCACback.src.DTO;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Controllers
{
    [ApiController]
    [Route("api/v1/event")]
    public class EventController
    {
        private readonly ServiceEvent service;

        public EventController(ServiceEvent service)
        {
            this.service = service;
        }

        [HttpPost]
        public Task<EventDTO> Create([FromBody] Event item)
        {
            return service.Create(item);
        }

        [HttpGet]
        public List<Event> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Task<Event> GetById([FromRoute]int id)
        {
            return service.GetById(id);
        }

        [HttpPut]
        public Task<EventDTO> UpdateEvent([FromBody]Event item)
        {
            return service.Update(item);
        }

        [HttpDelete]
        public Task<EventDTO> DeleteEvent([FromBody] Event item)
        {
            return service.Delete(item);
        }
    }
}
