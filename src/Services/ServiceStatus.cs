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
    public class ServiceStatus: IService<Status, Status>,IServiceGetAll<Status>
    {
        private readonly Repository repository;

        public ServiceStatus(Repository repository)
        {
            this.repository = repository;
        }

        public async Task<Status> Create(Status item)
        {
            repository.Status.Add(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public async Task<Status> Delete(Status item)
        {
            repository.Status.Remove(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public List<Status> GetAll()
        {
            List<Status> all = repository.Status.ToList();

            return all;
        }

        public async Task<Status> GetById(int id)
        {
            Status status = await repository.Status.FirstOrDefaultAsync(h => h.Id == id);
            return status;
        }

        public async Task<Status> Update(Status item)
        {
            repository.Status.Update(item);
            await repository.SaveChangesAsync();
            return item;
        }
    }
}
