using Backend_SCAC.src.Repositories;
using Microsoft.AspNetCore.Mvc;
using SCACback.src.DTO;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Services
{
    public class Service : IService<EventDTO, Event>
    {
        private readonly Repository repository;

        public Service(Repository repository)
        {
            this.repository = repository;
        }

        public async Task<EventDTO> Create(Event item)
        {
            repository.Event.Add(item);
            await repository.SaveChangesAsync();

            return item.ToDTO();
        }

        public Task<ActionResult<EventDTO>> Delete(Event item)
        {
            throw new NotImplementedException();
        }

        public List<Task<ActionResult<EventDTO>>> GetAll(Event item)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<EventDTO>> GetById(Event item)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<EventDTO>> Update(Event item)
        {
            throw new NotImplementedException();
        }
    }
}
