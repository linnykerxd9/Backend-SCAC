using Backend_SCAC.src.Interfaces;
using Backend_SCAC.src.Repositories;
using Microsoft.EntityFrameworkCore;
using SCACback.src.DTO;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Services
{
    public class ServiceVindication : IService<VindicationDTO, Vindication>, IServiceGet<Vindication>
    {
        private readonly Repository repository;

        public ServiceVindication(Repository repository)
        {
            this.repository = repository;
        }

        public async Task<VindicationDTO> Create(Vindication item)
        {
            repository.Vindication.Add(item);
            await repository.SaveChangesAsync();

            return item.ToDTO();
        }

        public async Task<VindicationDTO> Delete(Vindication item)
        {
            repository.Vindication.Remove(item);
            await repository.SaveChangesAsync();

            return item.ToDTO();

        }

        public List<Vindication> GetAll()
        {
            List<Vindication> all = repository.Vindication.Include("CommunityLeader")
                                                          .Include("Resident")
                                                          .Include("Status")
                                                          .Include("OrgPublic")
                                                          .Include("Priority")
                                                          .ToList();
           
            return all;
        }

        public async Task<Vindication> GetById(int id)
        {
            Vindication vindication = await repository.Vindication.Include("CommunityLeader")
                                                                  .Include("Resident")
                                                                  .Include("Status")
                                                                  .Include("OrgPublic")
                                                                  .Include("Priority")
                                                                  .FirstOrDefaultAsync(h => h.Id == id);
              return vindication;
        }

        public async Task<VindicationDTO> Update(Vindication item)
        {
            repository.Vindication.Update(item);
            await repository.SaveChangesAsync();
            return item.ToDTO();
        }
    }
}
