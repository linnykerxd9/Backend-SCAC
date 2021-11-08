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
    public class ServiceResident : IService<Resident, Resident>, IServiceGetAll<Resident> 
    {
        private readonly Repository repository;

        public ServiceResident(Repository repository)
        {
            this.repository = repository;
        }

        public async Task<Resident> Create(Resident item)
        {
            repository.Resident.Add(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public async Task<Resident> Delete(Resident item)
        {
            repository.Resident.Remove(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public List<Resident> GetAll()
        {
            List<Resident> all = repository.Resident.ToList();

            return all;
        }

        public async Task<Resident> GetById(int id)
        {
            Resident resident = await repository.Resident.FirstOrDefaultAsync(h => h.Id == id);
            return resident;

        }

        public  async Task<Resident> Update(Resident item)
        {
            repository.Resident.Update(item);
            await repository.SaveChangesAsync();
            return item;
        }
    }
}
