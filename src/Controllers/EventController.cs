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

    }
}
