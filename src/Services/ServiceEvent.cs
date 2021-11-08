using Backend_SCAC.src.Interfaces;
using Backend_SCAC.src.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCACback.src.DTO;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Services
{
    public class ServiceEvent : IService<EventDTO, Event>, IServiceGet<Event>
    {
        private readonly Repository repository;

        public ServiceEvent(Repository repository)
        {
            this.repository = repository;
        }

        public async Task<EventDTO> Create(Event item)
        {
            repository.Event.Add(item);
            await repository.SaveChangesAsync();

            return item.ToDTO();
        }

        public async Task<EventDTO> Delete(Event item)
        {
            repository.Event.Remove(item);
            await repository.SaveChangesAsync();

            return item.ToDTO();
        }

        public  List<Event> GetAll()
        {
            List<Event> all = repository.Event.Include("Status").ToList();

            return all;
     
        }

        public async Task<Event> GetById(int id)
        {
            Event queryEvent = await repository.Event.Include("Status")
                                                     .FirstOrDefaultAsync(h => h.Id == id);

            return queryEvent;
        }

        public async Task<EventDTO> Update(Event item)
        {
             repository.Event.Update(item);
            await repository.SaveChangesAsync();
            return item.ToDTO();
        }

    }
}
