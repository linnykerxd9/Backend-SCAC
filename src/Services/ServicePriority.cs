using Backend_SCAC.src.Interfaces;
using Backend_SCAC.src.Repositories;
using Microsoft.EntityFrameworkCore;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Services
{
    public class ServicePriority : IService<Priority, Priority>, IServiceGet<Priority>
    {
        private readonly Repository repository;

        public ServicePriority(Repository repository)
        {
            this.repository = repository;
        }

        public async Task<Priority> Create(Priority item)
        {
            repository.Priority.Add(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public async Task<Priority> Delete(Priority item)
        {
            repository.Priority.Remove(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public List<Priority> GetAll()
        {
            List<Priority> all = repository.Priority.ToList();

            return all;
        }

        public async Task<Priority> GetById(int id)
        {
            Priority priority = await repository.Priority.FirstOrDefaultAsync(h => h.Id == id);
            return priority;

        }

        public async Task<Priority> Update(Priority item)
        {
            repository.Priority.Update(item);
            await repository.SaveChangesAsync();
            return item;
        }
    }
}
